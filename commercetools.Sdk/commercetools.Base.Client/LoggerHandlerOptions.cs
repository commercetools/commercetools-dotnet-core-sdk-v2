using System;
using System.Collections.Generic;
using commercetools.Base.Client.Error;
using Microsoft.Extensions.Logging;

namespace commercetools.Base.Client
{
    class LoggerHandlerOptions : ILoggerHandlerOptions
    {
        public LogLevel ResponseLogEvent { get; set; } = LogLevel.Information;
        public LogLevel DefaultExceptionLogEvent { get; set; } = LogLevel.Error;
        public Dictionary<Type, LogLevel> ExceptionLogEvents { get; set; } = new Dictionary<Type, LogLevel>()
        {
            { typeof(NotFoundException), LogLevel.Information }
        };
    }
}