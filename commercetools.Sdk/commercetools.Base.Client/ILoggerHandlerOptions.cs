using System;
using System.Collections.Generic;
using Microsoft.Extensions.Logging;

namespace commercetools.Base.Client
{
    public interface ILoggerHandlerOptions
    {
        LogLevel ResponseLogEvent { get; }
        LogLevel DefaultExceptionLogEvent { get; }
        Dictionary<Type, LogLevel> ExceptionLogEvents { get; }
    }
}