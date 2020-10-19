using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net.Http;
using commercetools.Base.Client;
using commercetools.Base.Client.Middlewares;
using commercetools.Base.Client.Tokens;
using commercetools.Base.Registration;
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
        
        public static IDictionary<string, IHttpClientBuilder> UseHttpApi(this IServiceCollection services, IConfiguration configuration, IList<string> clients, Func<IServiceProvider, ISerializerService> serializerFactory)
        {
            if (clients.Count() == 1)
            {
                return services.UseSingleClient(configuration, clients.First(), serializerFactory);
            }
        
            return services.UseMultipleClients(configuration, clients, serializerFactory);
        }

        private static IDictionary<string, IHttpClientBuilder> UseMultipleClients(this IServiceCollection services, IConfiguration configuration, IList<string> clients, Func<IServiceProvider, ISerializerService> serializerFactory)
        {
            var builders = new ConcurrentDictionary<string, IHttpClientBuilder>();
            foreach (string clientName in clients)
            {
                IClientConfiguration clientConfiguration = configuration.GetSection(clientName).Get<ClientConfiguration>();
                Validator.ValidateObject(clientConfiguration, new ValidationContext(clientConfiguration), true);
        
                builders.TryAdd(clientName, services.SetupClient(clientName));
                services.AddSingleton(c =>
                {
                    var client = ClientFactory.Create(clientConfiguration, c.GetService<IHttpClientFactory>(), serializerFactory(c));
                    client.Name = clientName;
                    return client;
                });
            }
        
            return builders;
        }
        
        private static IDictionary<string, IHttpClientBuilder> UseSingleClient(this IServiceCollection services, IConfiguration configuration, string clientName, Func<IServiceProvider, ISerializerService> serializerFactory)
        {
            IClientConfiguration clientConfiguration = configuration.GetSection(clientName).Get<ClientConfiguration>();
            Validator.ValidateObject(clientConfiguration, new ValidationContext(clientConfiguration), true);
        
            services.AddSingleton(c =>
            {
                var client = ClientFactory.Create(clientConfiguration, c.GetService<IHttpClientFactory>(), serializerFactory(c));
                client.Name = clientName;
                return client;
            });
        
            var builders = new ConcurrentDictionary<string, IHttpClientBuilder>();
            builders.TryAdd(clientName, services.SetupClient(clientName));
        
            return builders;
        }

        private static IHttpClientBuilder SetupClient(this IServiceCollection services, string clientName)
        {
            var httpClientBuilder = services.AddHttpClient(clientName);

            return httpClientBuilder;
        }
    }
}
