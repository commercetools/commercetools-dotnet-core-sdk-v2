using System;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;

namespace commercetools.Base.Client
{
    public class DefaultHttpLogger : IHttpLogger
    {
        public void Debug(ILogger logger, HttpRequestMessage request)
        {
            if (logger.IsEnabled(LogLevel.Debug))
            {
                logger.LogDebug("{HttpMethod} {Uri} {Headers}", request.Method.Method,
                    request.RequestUri.AbsoluteUri, Redact(request.Headers));
            }
        }

        public async Task Trace(ILogger logger, HttpRequestMessage request)
        {
            if (logger.IsEnabled(LogLevel.Trace))
            {
                var body = await (request.Content?.ReadAsStringAsync() ?? Task.FromResult(""));
                logger.LogTrace("{HttpMethod} {Uri} {Headers} {Body}", request.Method.Method,
                    request.RequestUri.AbsoluteUri, Redact(request.Headers), SecuredBody(body));
            }
        }
        
        public void Log(ILogger logger, LogLevel level, HttpRequestMessage request, HttpResponseMessage response, long elapsed)
        {
            if (logger.IsEnabled(level))
            {
                logger.Log(level, "{HttpMethod} {Uri} {StatusCode} {Timing} {CorrelationId} {ServerTiming}", request.Method.Method,
                    request.RequestUri.AbsoluteUri, (int)response.StatusCode, elapsed, GetCorrelationId(response.Headers), GetServerTiming(response.Headers));
            }
        }

        public void Info(ILogger logger, HttpRequestMessage request, HttpResponseMessage response, long elapsed)
        {
            Log(logger, LogLevel.Information, request, response, elapsed);
        }

        public void Error(ILogger logger, HttpRequestMessage request, HttpResponseMessage response, long elapsed)
        {
            Log(logger, LogLevel.Error, request, response, elapsed);
        }

        public void Error(ILogger logger, HttpRequestMessage request, ApiHttpException exception, long elapsed)
        {
            if (logger.IsEnabled(LogLevel.Error))
            {
                logger.LogError("{HttpMethod} {Uri} {StatusCode} {Timing} {CorrelationId} {ServerTiming}", request.Method.Method,
                    request.RequestUri.AbsoluteUri, exception.StatusCode, elapsed, GetCorrelationId(exception.Headers), GetServerTiming(exception.Headers));
            }
        }

        public async Task Trace(ILogger logger, HttpRequestMessage request, HttpResponseMessage response)
        {
            if (logger.IsEnabled(LogLevel.Trace))
            {
                var body = await (response.Content?.ReadAsStringAsync() ?? Task.FromResult(""));
                logger.LogTrace("{HttpMethod} {Uri} {StatusCode} {Headers} {Body}", request.Method.Method,
                    request.RequestUri.AbsoluteUri, (int)response.StatusCode, Redact(request.Headers), SecuredBody(body));
            }
        }
        
        private static string Redact(HttpRequestHeaders headers)
        {
            var headString = from header in headers
                where header.Key.ToLower() != "authorization"
                select header.Key + ": " + string.Join(", ", header.Value);

            return "[" + string.Join(", ", headString) + "]";
        }

        private static string SecuredBody(string body)
        {
            if (body != null)
                return Regex.Replace(body, "(\"\\w*([Pp]ass|access_token|refresh_token)\\w*\"):\\W*\"[^\"]*\"",
                "$1:\"**removed from output**\"");
            return null;
        }

        private static string GetCorrelationId(ApiHttpHeaders headers)
        {
            return headers.GetFirst("X-Correlation-Id") ?? "-";
        }
        
        private static string GetCorrelationId(HttpResponseHeaders headers)
        {
            var correlationId = "-";

            if (headers.TryGetValues("X-Correlation-ID", out var values))
            {
                correlationId = values.First();
            }

            return correlationId;
        }
        
        private static string GetServerTiming(HttpResponseHeaders headers)
        {
            var serverTiming = "-";

            if (headers.TryGetValues("Server-Timing", out var values))
            {
                serverTiming = values.First();
            }

            return serverTiming;
        }
        
        private static string GetServerTiming(ApiHttpHeaders headers)
        {
            return headers.GetFirst("Server-Timing") ?? "-";
        }

    }
}