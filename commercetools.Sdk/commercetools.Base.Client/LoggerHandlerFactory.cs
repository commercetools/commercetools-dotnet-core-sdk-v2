using System.Net.Http;
using Microsoft.Extensions.Logging;

namespace commercetools.Base.Client
{
    public class LoggerHandlerFactory : ILoggerHandlerFactory
    {
        private readonly ILoggerFactory _loggerFactory;

        private readonly IHttpLogger _httpLogger;

        private readonly ILoggerHandlerOptions _handlerOptions;

        public LoggerHandlerFactory(ILoggerFactory loggerFactory, IHttpLogger httpLogger = null, ILoggerHandlerOptions options = null)
        {
            _loggerFactory = loggerFactory;
            _httpLogger = httpLogger;
            _handlerOptions = options;
        }

        public DelegatingHandler Create()
        {
            return new LoggerHandler(_loggerFactory, _httpLogger, _handlerOptions);
        }
    }
}