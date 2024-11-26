using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;

namespace commercetools.Base.Client
{
    public interface IHttpLogger
    {
        void Log(ILogger logger, LogLevel level, HttpRequestMessage request);
        void Log(ILogger logger, LogLevel level, HttpRequestMessage request, HttpResponseMessage response, long elapsed);
        void Log(ILogger logger, LogLevel logLevel, HttpRequestMessage request, ApiHttpException exception, long elapsed);

        Task LogRequestBody(ILogger logger, LogLevel logLevel, HttpRequestMessage request);

        Task LogResponseBody(ILogger logger, LogLevel logLevel, HttpRequestMessage request,
            HttpResponseMessage response, long elapsed);
    }
}