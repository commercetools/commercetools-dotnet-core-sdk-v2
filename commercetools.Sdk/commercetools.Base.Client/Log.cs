using System;
using System.Linq;
using System.Net;
using System.Net.Http;
using Microsoft.Extensions.Logging;

namespace commercetools.Base.Client
{
    internal static class Log
    {
        private static readonly Func<ILogger, HttpMethod, Uri, string, IDisposable> BeginRequestPipelineScopeValue =
            LoggerMessage.DefineScope<HttpMethod, Uri, string>(
                "HTTP {HttpMethod} {Uri} {CorrelationId}");

        private static readonly Action<ILogger, HttpMethod, Uri, string, Exception> RequestPipelineStartValue =
            LoggerMessage.Define<HttpMethod, Uri, string>(
                LogLevel.Information,
                EventIds.PipelineStart,
                "Start processing HTTP request {HttpMethod} {Uri} [Correlation: {CorrelationId}]");

        private static readonly Action<ILogger, HttpStatusCode, Exception> RequestPipelineEndValue =
            LoggerMessage.Define<HttpStatusCode>(
                LogLevel.Information,
                EventIds.PipelineEnd,
                "End processing HTTP request - {StatusCode}");

        public static IDisposable BeginRequestPipelineScope(ILogger logger, HttpRequestMessage request)
        {
            var correlationId = GetCorrelationIdFromRequest(request);
            return BeginRequestPipelineScopeValue(logger, request.Method, request.RequestUri, correlationId);
        }

        public static void RequestPipelineStart(ILogger logger, HttpRequestMessage request)
        {
            var correlationId = GetCorrelationIdFromRequest(request);
            RequestPipelineStartValue(logger, request.Method, request.RequestUri, correlationId, null);
        }

        public static void RequestPipelineEnd(ILogger logger, HttpResponseMessage response)
        {
            RequestPipelineEndValue(logger, response.StatusCode, null);
        }

        private static string GetCorrelationIdFromRequest(HttpRequestMessage request)
        {
            var correlationId = "Not set";

            if (request.Headers.TryGetValues("X-Correlation-ID", out var values))
            {
                correlationId = values.First();
            }

            return correlationId;
        }
    }
}