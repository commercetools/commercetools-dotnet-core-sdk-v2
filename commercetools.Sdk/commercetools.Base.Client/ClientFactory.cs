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
            ISerializerService serializerService,
            ITokenStoreManager tokenStoreManager = null)
        {
            var tokenStore = tokenStoreManager ?? new InMemoryTokenStoreManager();
            var authClient = factory.CreateClient(DefaultClientNames.Authorization);
            var tokenProvider = CreateClientCredentialsTokenProvider(configuration, authClient, tokenStore);
            return new CtpClient(
                CreateMiddlewareStack(clientName, configuration, factory, tokenProvider),
                serializerService
            );
        }
        public static IClient CreatePasswordFlow(
            string clientName,
            IClientConfiguration configuration,
            IHttpClientFactory factory,
            ISerializerService serializerService,
            IUserCredentialsStoreManager userCredentials)
        {
            var authClient = factory.CreateClient(DefaultClientNames.Authorization);
            var tokenProvider = CreatePasswordTokenProvider(configuration, authClient, userCredentials);
            return new CtpClient(
                CreateMiddlewareStack(clientName, configuration, factory, tokenProvider),
                serializerService
            );
        }
        
        public static IClient CreateAnonymousFlow(
            string clientName,
            IClientConfiguration configuration,
            IHttpClientFactory factory,
            ISerializerService serializerService,
            IAnonymousCredentialsStoreManager anonymousCredentials)
        {
            var authClient = factory.CreateClient(DefaultClientNames.Authorization);
            var tokenProvider = CreateAnonymousSessionTokenProvider(configuration, authClient, anonymousCredentials);
            return new CtpClient(
                CreateMiddlewareStack(clientName, configuration, factory, tokenProvider),
                serializerService
            );
        }

        public static Middleware CreateMiddlewareStack(string clientName, IClientConfiguration configuration,
            IHttpClientFactory factory, ITokenProvider tokenProvider)
        {
            var httpClient = factory.CreateClient(clientName);
            httpClient.BaseAddress = new Uri(configuration.ApiBaseAddress);

            List<DelegatingMiddleware> handlers = new List<DelegatingMiddleware>()
            {
                CreateAuthMiddleware(tokenProvider),
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

        public static CorrelationIdMiddleware CreateCorrelationIdMiddleware(
            ICorrelationIdProvider correlationIdProvider)
        {
            return new CorrelationIdMiddleware(correlationIdProvider);
        }
        

        private static ITokenProvider CreateClientCredentialsTokenProvider(IClientConfiguration configuration,
            HttpClient httpClient, ITokenStoreManager tokenStoreManager)
        {
            return new ClientCredentialsTokenProvider(
                configuration,
                httpClient,
                tokenStoreManager,
                new TokenSerializerService()
            );
        }

        private static ITokenProvider CreatePasswordTokenProvider(IClientConfiguration configuration,
            HttpClient httpClient, IUserCredentialsStoreManager userCredentials)
        {
            return new PasswordTokenProvider(
                configuration,
                httpClient,
                userCredentials,
                new TokenSerializerService()
            );
        }

        private static ITokenProvider CreateAnonymousSessionTokenProvider(IClientConfiguration configuration,
            HttpClient httpClient, IAnonymousCredentialsStoreManager anonymousCredentials)
        {
            return new AnonymousSessionTokenProvider(
                configuration,
                httpClient,
                anonymousCredentials,
                new TokenSerializerService()
            );
        }
    }
}