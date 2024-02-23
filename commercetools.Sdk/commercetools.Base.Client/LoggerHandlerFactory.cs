using System.Net.Http;
using Microsoft.Extensions.Logging;

namespace commercetools.Base.Client
{
    public class LoggerHandlerFactory : ILoggerHandlerFactory
    {
        private readonly ILoggerFactory loggerFactory;

        public LoggerHandlerFactory(ILoggerFactory loggerFactory)
        {
            this.loggerFactory = loggerFactory;
        }

        public DelegatingHandler Create()
        {
            return new LoggerHandler(loggerFactory);
        }
    }
}