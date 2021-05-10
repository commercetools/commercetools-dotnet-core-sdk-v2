using System;
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
using Microsoft.Extensions.Logging;

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
            Func<string, IConfiguration , IServiceProvider, ITokenProvider> tokenProviderSupplier)
        {
            if (clients.Count() == 1)
            {
                return services.UseSingleClient(configuration, clients.First(), serializerFactory, errorResponseTypeMapper, tokenProviderSupplier);
            }

            return services.UseMultipleClients(configuration, clients, serializerFactory, errorResponseTypeMapper, tokenProviderSupplier);
        }

        private static IDictionary<string, IHttpClientBuilder> UseMultipleClients(this IServiceCollection services,
            IConfiguration configuration, IList<string> clients,
            Func<IServiceProvider, ISerializerService> serializerFactory,
            Func<HttpResponseMessage, Type> errorResponseTypeMapper,
            Func<string, IConfiguration , IServiceProvider, ITokenProvider> tokenProviderSupplier)
        {
            var builders = new ConcurrentDictionary<string, IHttpClientBuilder>();
            foreach (string clientName in clients)
            {
                IClientConfiguration clientConfiguration =
                    configuration.GetSection(clientName).Get<ClientConfiguration>();
                Validator.ValidateObject(clientConfiguration, new ValidationContext(clientConfiguration), true);

                builders.TryAdd(clientName, services.SetupClient(clientName, errorResponseTypeMapper, serializerFactory));
                services.AddSingleton(serviceProvider =>
                {
                    var client = ClientFactory.Create(clientName, clientConfiguration,
                        serviceProvider.GetService<IHttpClientFactory>(),
                        serializerFactory(serviceProvider),
                        tokenProviderSupplier(clientName, configuration, serviceProvider));
                    client.Name = clientName;
                    return client;
                });
            }

            return builders;
        }

        private static IDictionary<string, IHttpClientBuilder> UseSingleClient(this IServiceCollection services,
            IConfiguration configuration, string clientName,
            Func<IServiceProvider, ISerializerService> serializerFactory,
            Func<HttpResponseMessage, Type> errorResponseTypeMapper,
            Func<string, IConfiguration , IServiceProvider, ITokenProvider> tokenProviderSupplier)
        {
            IClientConfiguration clientConfiguration = configuration.GetSection(clientName).Get<ClientConfiguration>();
            Validator.ValidateObject(clientConfiguration, new ValidationContext(clientConfiguration), true);

            services.AddSingleton(serviceProvider =>
            {
                var client = ClientFactory.Create(clientName, clientConfiguration,
                    serviceProvider.GetService<IHttpClientFactory>(),
                    serializerFactory(serviceProvider),
                    tokenProviderSupplier(clientName, configuration, serviceProvider));
                client.Name = clientName;
                return client;
            });

            var builders = new ConcurrentDictionary<string, IHttpClientBuilder>();
            builders.TryAdd(clientName, services.SetupClient(clientName, errorResponseTypeMapper, serializerFactory));

            return builders;
        }

        public static IHttpClientBuilder SetupClient(this IServiceCollection services, string clientName, Func<HttpResponseMessage, Type> errorResponseTypeMapper, Func<IServiceProvider, ISerializerService> serializerFactory)
        {
            var httpClientBuilder = services.AddHttpClient(clientName)
                .ConfigureHttpClient(client =>
                {
                    client.DefaultRequestHeaders.AcceptEncoding.ParseAdd("gzip");
                    client.DefaultRequestHeaders.AcceptEncoding.ParseAdd("deflate");
                    client.DefaultRequestHeaders.UserAgent.ParseAdd(new UserAgentProvider().UserAgent);
                })
                .ConfigureHttpMessageHandlerBuilder(builder =>
                {
                    builder.PrimaryHandler = new HttpClientHandler
                    {
                        AutomaticDecompression = DecompressionMethods.Deflate | DecompressionMethods.GZip
                    };
                })
                .AddHttpMessageHandler(c => new ErrorHandler(message => serializerFactory(c).Deserialize(errorResponseTypeMapper(message), message.ExtractResponseBody())))
                .AddHttpMessageHandler(c => new LoggerHandler(c.GetService<ILoggerFactory>()));

            return httpClientBuilder;
        }
    }
}