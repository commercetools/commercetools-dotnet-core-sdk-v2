using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Net.Http;
using commercetools.Base.Client.Middlewares;
using commercetools.Base.Client.Tokens;
using commercetools.Base.Serialization;

namespace commercetools.Base.Client
{
    public class ClientFactory
    {
        [Obsolete("Use ClientBuilder instead")]
        public static IClient Create(
            string clientName,
            IClientConfiguration configuration,
            IHttpClientFactory factory,
            ISerializerService serializerService,
            ITokenProvider tokenProvider,
            bool readResponseAsStream = false,
            ICorrelationIdProvider correlationIdProvider = null,
            Version httpVersion = null)
        {
            return new ClientBuilder()
                {
                    ClientName = clientName,
                    ClientConfiguration = configuration,
                    HttpClient = factory.CreateClient(clientName),
                    SerializerService = serializerService,
                    TokenProvider = tokenProvider,
                    ReadResponseAsStream = readResponseAsStream,
                    CorrelationIdProvider = correlationIdProvider,
                    HttpVersion = httpVersion
                }.Build();
        }

        [Obsolete("Use ClientBuilder.CreateMiddlewareStack instead")]
        public static Middleware CreateMiddlewareStack(string clientName, IClientConfiguration configuration,
            IHttpClientFactory factory, ITokenProvider tokenProvider, bool readResponseAsStream = false, ICorrelationIdProvider correlationIdProvider = null, Version httpVersion = null)
        {
            return ClientBuilder.CreateMiddlewareStack(configuration, factory.CreateClient(clientName), tokenProvider, new List<DelegatingMiddleware>(),
                readResponseAsStream, correlationIdProvider, httpVersion);
        }

        [Obsolete("Use ClientBuilder.CreateAuthMiddleware instead")]
        public static AuthorizationMiddleware CreateAuthMiddleware(ITokenProvider tokenProvider)
        {
            return ClientBuilder.CreateAuthMiddleware(tokenProvider);
        }

        [Obsolete("Use ClientBuilder.CreateCorrelationIdMiddleware instead")]
        public static CorrelationIdMiddleware CreateCorrelationIdMiddleware(
            ICorrelationIdProvider correlationIdProvider)
        {
            return ClientBuilder.CreateCorrelationIdMiddleware(correlationIdProvider);
        }

        [Obsolete("Use ClientBuilder.CreateVersionMiddleware instead")]
        public static VersionMiddleware CreateVersionMiddleware(Version httpVersion)
        {
            return ClientBuilder.CreateVersionMiddleware(httpVersion);
        }
    }
}