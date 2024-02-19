using System.Net.Http;
using Microsoft.Extensions.Logging;

namespace commercetools.Base.Client
{
    public class LoggerHandlerFactory : ILoggerHandlerFactory
    {
        private readonly ILoggerFactory _loggerFactory;

        private readonly IHttpLogger _httpLogger;

        public LoggerHandlerFactory(ILoggerFactory loggerFactory, IHttpLogger httpLogger = null)
        {
            _loggerFactory = loggerFactory;
            _httpLogger = httpLogger;
        }

        public DelegatingHandler Create()
        {
            return new LoggerHandler(_loggerFactory, _httpLogger);
        }
    }
}