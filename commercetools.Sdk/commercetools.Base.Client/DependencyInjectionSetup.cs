﻿using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net;
using System.Net.Http;
using commercetools.Base.Client.Middlewares;
using commercetools.Base.Client.Tokens;
using commercetools.Base.Serialization;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace commercetools.Base.Client
{
    public static class DependencyInjectionSetup
    {
        public static void UseHttp(this IServiceCollection services)
        {
            services.AddHttpClient();
        }

        public static IDictionary<string, IHttpClientBuilder> UseHttpApi(this IServiceCollection services,
            IConfiguration configuration, IList<string> clients,
            Func<IServiceProvider, ISerializerService> serializerFactory,
            Func<HttpResponseMessage, Type> errorResponseTypeMapper,
            Func<string, IConfiguration, IServiceProvider, ITokenProvider> tokenProviderSupplier,
            ClientOptions options = null)
        {
            options ??= new ClientOptions();
            if (clients.Count() == 1)
            {
                return services.UseSingleClient(configuration, clients.First(), serializerFactory, errorResponseTypeMapper, tokenProviderSupplier, options);
            }

            return services.UseMultipleClients(configuration, clients, serializerFactory, errorResponseTypeMapper, tokenProviderSupplier, options);
        }

        private static IDictionary<string, IHttpClientBuilder> UseMultipleClients(this IServiceCollection services,
            IConfiguration configuration, IList<string> clients,
            Func<IServiceProvider, ISerializerService> serializerFactory,
            Func<HttpResponseMessage, Type> errorResponseTypeMapper,
            Func<string, IConfiguration, IServiceProvider, ITokenProvider> tokenProviderSupplier,
            ClientOptions options)
        {
            var builders = new ConcurrentDictionary<string, IHttpClientBuilder>();

            
            clients.ToList().ForEach(clientName =>
            {
                IClientConfiguration clientConfiguration =
                    configuration.GetSection(clientName).Get<ClientConfiguration>();
                Validator.ValidateObject(clientConfiguration, new ValidationContext(clientConfiguration), true);
                
                builders.TryAdd(clientName, services.SetupClient(clientName, errorResponseTypeMapper, serializerFactory, options));
                services.AddSingleton(serviceProvider =>
                {
                    var client = ClientFactory.Create(clientName, clientConfiguration,
                        serviceProvider.GetService<IHttpClientFactory>(),
                        serializerFactory(serviceProvider),
                        tokenProviderSupplier(clientName, configuration, serviceProvider),
                        options.ReadResponseAsStream,
                        serviceProvider.GetService<ICorrelationIdProvider>());
                    client.Name = clientName;
                    return client;
                });
            });

            return builders;
        }

        private static IDictionary<string, IHttpClientBuilder> UseSingleClient(this IServiceCollection services,
            IConfiguration configuration, string clientName,
            Func<IServiceProvider, ISerializerService> serializerFactory,
            Func<HttpResponseMessage, Type> errorResponseTypeMapper,
            Func<string, IConfiguration, IServiceProvider, ITokenProvider> tokenProviderSupplier,
            ClientOptions options)
        {
            IClientConfiguration clientConfiguration = configuration.GetSection(clientName).Get<ClientConfiguration>();
            Validator.ValidateObject(clientConfiguration, new ValidationContext(clientConfiguration), true);

            services.AddSingleton(serviceProvider =>
            {
                var client = ClientFactory.Create(clientName, clientConfiguration,
                    serviceProvider.GetService<IHttpClientFactory>(),
                    serializerFactory(serviceProvider),
                    tokenProviderSupplier(clientName, configuration, serviceProvider),
                    options.ReadResponseAsStream,
                    serviceProvider.GetService<ICorrelationIdProvider>());

                client.Name = clientName;
                return client;
            });

            var builders = new ConcurrentDictionary<string, IHttpClientBuilder>();
            builders.TryAdd(clientName, services.SetupClient(clientName, errorResponseTypeMapper, serializerFactory, options));

            return builders;
        }

        public static IHttpClientBuilder SetupClient(this IServiceCollection services, string clientName, Func<HttpResponseMessage, Type> errorResponseTypeMapper, Func<IServiceProvider, ISerializerService> serializerFactory, ClientOptions options = null)
        {
            options ??= new ClientOptions();
            services.AddSingleton<IUserAgentProvider, UserAgentProvider>();
            services.AddSingleton<ILoggerHandlerFactory, LoggerHandlerFactory>();
            var httpClientBuilder = services.AddHttpClient(clientName)
                .ConfigureHttpClient((provider, client) =>
                {
                    if (options.DecompressionMethods.HasFlag(DecompressionMethods.GZip))
                    {
                        client.DefaultRequestHeaders.AcceptEncoding.ParseAdd("gzip");
                    }
                    if (options.DecompressionMethods.HasFlag(DecompressionMethods.Deflate))
                    {
                        client.DefaultRequestHeaders.AcceptEncoding.ParseAdd("deflate");
                    }
                    var userAgentProvider = provider.GetService<IUserAgentProvider>() ?? new UserAgentProvider();
                    client.DefaultRequestHeaders.UserAgent.ParseAdd(userAgentProvider.UserAgent);
                })
                .ConfigureHttpMessageHandlerBuilder(builder =>
                {
                    builder.PrimaryHandler = new HttpClientHandler
                    {
                        AutomaticDecompression = options.DecompressionMethods
                    };
                })
                .AddHttpMessageHandler(c => new ErrorHandler(message => serializerFactory(c).Deserialize(errorResponseTypeMapper(message), message.ExtractResponseBody())))
                .AddHttpMessageHandler(c => c.GetService<ILoggerHandlerFactory>().Create());

            return httpClientBuilder;
        }
    }
}