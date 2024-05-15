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
            ICorrelationIdProvider correlationIdProvider = null)
        {
            Validator.ValidateObject(configuration, new ValidationContext(configuration), true);
            if (readResponseAsStream && serializerService is IStreamSerializerService streamSerializer)
            {
                return new StreamCtpClient(
                    CreateMiddlewareStack(clientName, configuration, factory, tokenProvider, true, correlationIdProvider),
                    streamSerializer,
                    clientName
                );
            }
            return new CtpClient(
                CreateMiddlewareStack(clientName, configuration, factory, tokenProvider, false, correlationIdProvider),
                serializerService,
                clientName
            );
        }

        public static Middleware CreateMiddlewareStack(string clientName, IClientConfiguration configuration,
            IHttpClientFactory factory, ITokenProvider tokenProvider, bool readResponseAsStream = false, ICorrelationIdProvider correlationIdProvider = null)
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
    }
}