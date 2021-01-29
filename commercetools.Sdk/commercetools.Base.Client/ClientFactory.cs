using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Net.Http;
using System.Security;
using commercetools.Base.Client.Middlewares;
using commercetools.Base.Client.Tokens;
using commercetools.Base.Serialization;

namespace commercetools.Base.Client
{
    public class ClientFactory
    {
        public static IClient Create(
            string clientName,
            IClientConfiguration configuration,
            IHttpClientFactory factory,
            ISerializerService serializerService)
        {
            return new CtpClient(
                CreateMiddlewareStack(clientName, configuration, factory),
                serializerService
            );
        }

        public static Middleware CreateMiddlewareStack(string clientName, IClientConfiguration configuration, IHttpClientFactory factory)
        {
            var httpClient = factory.CreateClient(clientName);
            httpClient.BaseAddress = new Uri(configuration.ApiBaseAddress);

            var authClient = factory.CreateClient(DefaultClientNames.Authorization);
            
            List<DelegatingMiddleware> handlers = new List<DelegatingMiddleware>()
            {
                CreateAuthMiddleware(
                    CreateClientCredentialsProvider(configuration, authClient)
                ),
                CreateCorrelationIdMiddleware(
                    new DefaultCorrelationIdProvider(configuration)
                )
            };

            DelegatingMiddleware httpMiddleware = new HttpMiddleware(httpClient);
            foreach (var handler in handlers)
            {
                handler.InnerMiddleware = httpMiddleware;
                httpMiddleware = handler;
            }
            return httpMiddleware;
        }

        public static AuthorizationMiddleware CreateAuthMiddleware(ITokenProvider tokenProvider)
        {
            return new AuthorizationMiddleware(tokenProvider);
        }

        public static CorrelationIdMiddleware CreateCorrelationIdMiddleware(ICorrelationIdProvider correlationIdProvider)
        {
            return new CorrelationIdMiddleware(correlationIdProvider);
        }

        public static ITokenProvider CreateClientCredentialsProvider(IClientConfiguration configuration, HttpClient httpClient)
        {
            return new ClientCredentialsTokenProvider(
                configuration,
                httpClient,
                new InMemoryTokenStoreManager(),
                new TokenSerializerService()
            );
        }
    }
}