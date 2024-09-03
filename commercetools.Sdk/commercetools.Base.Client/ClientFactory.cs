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
            Validator.ValidateObject(configuration, new ValidationContext(configuration), true);
            if (readResponseAsStream && serializerService is IStreamSerializerService streamSerializer)
            {
                return new StreamCtpClient(
                    CreateMiddlewareStack(clientName, configuration, factory, tokenProvider, true, correlationIdProvider, httpVersion),
                    streamSerializer,
                    clientName
                );
            }
            return new CtpClient(
                CreateMiddlewareStack(clientName, configuration, factory, tokenProvider, false, correlationIdProvider, httpVersion),
                serializerService,
                clientName
            );
        }

        public static Middleware CreateMiddlewareStack(string clientName, IClientConfiguration configuration,
            IHttpClientFactory factory, ITokenProvider tokenProvider, bool readResponseAsStream = false, ICorrelationIdProvider correlationIdProvider = null, Version httpVersion = null)
        {
            var httpClient = factory.CreateClient(clientName);
            httpClient.BaseAddress = new Uri(configuration.ApiBaseAddress);

            List<DelegatingMiddleware> handlers = new List<DelegatingMiddleware>()
            {
                CreateAuthMiddleware(tokenProvider),
                CreateCorrelationIdMiddleware(
                    correlationIdProvider ?? new DefaultCorrelationIdProvider(configuration)
                )
            };
            if (httpVersion != null)
            {
                handlers.Add(CreateVersionMiddleware(httpVersion));
            }

            var httpMiddleware =
                readResponseAsStream ? (DelegatingMiddleware)new StreamHttpMiddleware(httpClient) : new HttpMiddleware(httpClient);
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

        public static VersionMiddleware CreateVersionMiddleware(Version httpVersion)
        {
            return new VersionMiddleware(httpVersion);
        }
    }
}