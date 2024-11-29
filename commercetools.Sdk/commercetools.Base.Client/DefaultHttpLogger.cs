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
        public async Task LogRequestBody(ILogger logger, LogLevel logLevel, HttpRequestMessage request)
        {
            if (logger.IsEnabled(logLevel))
            {
                var body = await (request.Content?.ReadAsStringAsync() ?? Task.FromResult(""));
                logger.Log(logLevel, "{HttpMethod} {Uri} {Headers} {Body}", request.Method.Method,
                    request.RequestUri.AbsoluteUri, RedactAuthorizationHeader(request.Headers), SecuredBody(body));
            }
        }

        public async Task LogResponseBody(ILogger logger, LogLevel logLevel, HttpRequestMessage request, HttpResponseMessage response, long elapsed)
        {
            if (logger.IsEnabled(logLevel))
            {
                var body = await (response.Content?.ReadAsStringAsync() ?? Task.FromResult(""));
                logger.Log(logLevel, "{HttpMethod} {Uri} {StatusCode} {Timing} {Headers} {Body}", request.Method.Method,
                    request.RequestUri.AbsoluteUri, (int)response.StatusCode, elapsed, RedactAuthorizationHeader(request.Headers), SecuredBody(body));
            }
        }

        public void Log(ILogger logger, LogLevel logLevel, HttpRequestMessage request)
        {
            if (logger.IsEnabled(logLevel))
            {
                logger.Log(logLevel, "{HttpMethod} {Uri} {Headers}", request.Method.Method,
                    request.RequestUri.AbsoluteUri, RedactAuthorizationHeader(request.Headers));
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

        public void Log(ILogger logger, LogLevel logLevel, HttpRequestMessage request, ApiHttpException exception, long elapsed)
        {
            if (logger.IsEnabled(logLevel))
            {
                logger.Log(logLevel, "{HttpMethod} {Uri} {StatusCode} {Timing} {CorrelationId} {ServerTiming}", request.Method.Method,
                    request.RequestUri.AbsoluteUri, exception.StatusCode, elapsed, GetCorrelationId(exception.Headers), GetServerTiming(exception.Headers));
            }
        }


        private static string RedactAuthorizationHeader(HttpRequestHeaders headers)
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
            return GetHeader(headers, "X-Correlation-ID");
        }

        private static string GetHeader(HttpResponseHeaders headers, string headerName)
        {
            var headerValue = "-";

            if (headers.TryGetValues(headerName, out var values))
            {
                headerValue = values.First();
            }

            return headerValue;
        }

        private static string GetServerTiming(HttpResponseHeaders headers)
        {
            return GetHeader(headers, "Server-Timing");
        }

        private static string GetServerTiming(ApiHttpHeaders headers)
        {
            return headers.GetFirst("Server-Timing") ?? "-";
        }

    }
}