using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Client;
using commercetools.Api.Client.Tokens;
using commercetools.Api.Serialization;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace commercetools.Api.DependencyInjection
{
    /// <summary>
    /// Contains extensions methods to use when setting up commercetools dependencies.
    /// </summary>
    public static class DependencyInjectionSetup
    {
        /// <summary>
        /// Adds concrete implementations necessary for running of the application to the service collection for a single client.
        /// </summary>
        /// <param name="services">The service collection.</param>
        /// <param name="configuration">The configuration.</param>
        /// <param name="clientName">The name of the client.</param>
        /// <param name="tokenFlow">The token flow.</param>
        public static IHttpClientBuilder UseCommercetools(this IServiceCollection services, IConfiguration configuration, string clientName = DefaultClientNames.Api, TokenFlow tokenFlow = TokenFlow.ClientCredentials)
        {
            var clients = new ConcurrentDictionary<string, TokenFlow>();
            clients.TryAdd(clientName, tokenFlow);
            return services.UseCommercetools(configuration, clients).Single().Value;
        }

        /// <summary>
        /// Adds concrete implementations necessary for running of the application to the service collection for multiple client.
        /// </summary>
        /// <param name="services">The service collection.</param>
        /// <param name="configuration">The configuration.</param>
        /// <param name="clients">The clients with the client name as the key and the token flow as they value.</param>
        public static IDictionary<string, IHttpClientBuilder> UseCommercetools(this IServiceCollection services, IConfiguration configuration, IDictionary<string, TokenFlow> clients)
        {
            services.UseSerialization();
            return services.UseHttpApi(configuration, clients);
        }

    }
}
