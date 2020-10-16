using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net.Http;
using commercetools.Base.Client;
using commercetools.Base.Client.DelegatingHandlers;
using commercetools.Base.Client.Tokens;
using commercetools.Base.Registration;
using commercetools.Base.Serialization;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace commercetools.Base.Client
{
    public static class DependencyInjectionSetup
    {
        public static IDictionary<string, IHttpClientBuilder> UseHttpApi(this IServiceCollection services, IConfiguration configuration, IDictionary<string, TokenFlow> clients)
        {
            if (clients.Count() == 1)
            {
                return services.UseSingleClient(configuration, clients.First().Key, clients.First().Value);
            }

            return services.UseMultipleClients(configuration, clients);
        }

        private static IDictionary<string, IHttpClientBuilder> UseMultipleClients(this IServiceCollection services, IConfiguration configuration, IDictionary<string, TokenFlow> clients)
        {
            services.UseHttpApiDefaults();
            var builders = new ConcurrentDictionary<string, IHttpClientBuilder>();
            foreach (KeyValuePair<string, TokenFlow> client in clients)
            {
                string clientName = client.Key;
                TokenFlow tokenFlow = client.Value;

                IClientConfiguration clientConfiguration = configuration.GetSection(clientName).Get<ClientConfiguration>();
                Validator.ValidateObject(clientConfiguration, new ValidationContext(clientConfiguration), true);

                builders.TryAdd(clientName, services.SetupClient(clientName, clientConfiguration, tokenFlow));
                services.AddSingleton<IClient>(c => new CtpClient(c.GetService<IHttpClientFactory>(), c.GetService<ISerializerService>(), c.GetService<IUserAgentProvider>()) { Name = clientName });
            }

            return builders;
        }

        private static IDictionary<string, IHttpClientBuilder> UseSingleClient(this IServiceCollection services, IConfiguration configuration, string clientName, TokenFlow tokenFlow)
        {
            IClientConfiguration clientConfiguration = configuration.GetSection(clientName).Get<ClientConfiguration>();
            Validator.ValidateObject(clientConfiguration, new ValidationContext(clientConfiguration), true);

            services.UseHttpApiDefaults();
            services.AddSingleton<IClient>(c => new CtpClient(c.GetService<IHttpClientFactory>(), c.GetService<ISerializerService>(), c.GetService<IUserAgentProvider>()) { Name = clientName });

            var builders = new ConcurrentDictionary<string, IHttpClientBuilder>();
            builders.TryAdd(clientName, services.SetupClient(clientName, clientConfiguration, tokenFlow));

            return builders;
        }

        private static IHttpClientBuilder SetupClient(this IServiceCollection services, string clientName, IClientConfiguration clientConfiguration, TokenFlow tokenFlow)
        {
            var httpClientBuilder = services.AddHttpClient(clientName)
                .ConfigureHttpClient(client =>
                    client.BaseAddress = new Uri(clientConfiguration.ApiBaseAddress))
                .AddHttpMessageHandler(c =>
                {
                    var providers = c.GetServices<ITokenProvider>();
                    var provider = providers.FirstOrDefault(tokenProvider => tokenProvider.TokenFlow == tokenFlow);
                    provider.ClientConfiguration = clientConfiguration;
                    return new AuthorizationHandler(provider);
                })
                .AddHttpMessageHandler(c =>
                {
                    var correlationIdProvider = c.GetServices<ICorrelationIdProvider>().FirstOrDefault();
                    correlationIdProvider.ClientConfiguration = clientConfiguration;
                    return new CorrelationIdHandler(correlationIdProvider);
                });
                /*
                .AddHttpMessageHandler(c =>
                    new ErrorHandler(new ApiExceptionFactory(clientConfiguration, c.GetService<ISerializerService>())))
                .AddHttpMessageHandler<LoggerHandler>();
                */

            return httpClientBuilder;
        }

        private static void UseHttpApiDefaults(this IServiceCollection services)
        {
            services.AddHttpClient(DefaultClientNames.Authorization);
            services.AddTransient<ITokenStoreManager, InMemoryTokenStoreManager>();
            services.RegisterAllTypes<ITokenProvider>(ServiceLifetime.Transient);
            services.AddSingleton<IUserAgentProvider, UserAgentProvider>();
            services.AddSingleton<ITokenSerializerService, TokenSerializerService>();
            services.AddSingleton<ICorrelationIdProvider, DefaultCorrelationIdProvider>();
        }
    }
}
