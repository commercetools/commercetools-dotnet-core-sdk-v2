using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;

namespace commercetools.Base.Client
{
    public interface IHttpLogger
    {
        void Debug(ILogger logger, HttpRequestMessage request);
        Task Trace(ILogger logger, HttpRequestMessage request);
        Task Trace(ILogger logger, HttpRequestMessage request, HttpResponseMessage response);

        void Log(ILogger logger, LogLevel level, HttpRequestMessage request, HttpResponseMessage response, long elapsed);

        void Info(ILogger logger, HttpRequestMessage request, HttpResponseMessage response, long elapsed);

        void Error(ILogger logger, HttpRequestMessage request, HttpResponseMessage response, long elapsed);

        void Error(ILogger logger, HttpRequestMessage request, ApiHttpException exception, long elapsed);
    }
}