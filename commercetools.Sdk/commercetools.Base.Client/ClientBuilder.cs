using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Net.Http;
using commercetools.Base.Client.Middlewares;
using commercetools.Base.Client.Tokens;
using commercetools.Base.Serialization;

namespace commercetools.Base.Client;

public class ClientBuilder
{
    public string ClientName { get; set; }
    public IClientConfiguration ClientConfiguration { get; set; }
    public ISerializerService SerializerService { get; set; }
    public ITokenProvider TokenProvider { get; set; }
    public bool ReadResponseAsStream { get; set; } = true;
    public ICorrelationIdProvider CorrelationIdProvider { get; set; }
    
    [Obsolete("Set default HttpVersion in HttpClient instead")]
    public Version HttpVersion { get; set; }
    public IEnumerable<DelegatingMiddleware> Middlewares { get; set; } = new List<DelegatingMiddleware>();
    public HttpClient HttpClient { get; set; }

    public IClient Build()
    {
        Validator.ValidateObject(ClientConfiguration, new ValidationContext(ClientConfiguration), true);
        if (ReadResponseAsStream && SerializerService is IStreamSerializerService streamSerializer)
        {
            return new StreamCtpClient(
                CreateMiddlewareStack(ClientConfiguration, HttpClient, TokenProvider, Middlewares, true, CorrelationIdProvider, HttpVersion),
                streamSerializer,
                ClientName
            );
        }
        return new CtpClient(
            CreateMiddlewareStack(ClientConfiguration, HttpClient, TokenProvider, Middlewares, false, CorrelationIdProvider, HttpVersion),
            SerializerService,
            ClientName
        );
    }

    public static Middleware CreateMiddlewareStack(IClientConfiguration configuration,
        HttpClient httpClient, ITokenProvider tokenProvider, IEnumerable<DelegatingMiddleware> middlewares, bool readResponseAsStream = false, ICorrelationIdProvider correlationIdProvider = null, Version httpVersion = null)
    {
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
        if (middlewares != null)
            handlers.AddRange(middlewares);

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