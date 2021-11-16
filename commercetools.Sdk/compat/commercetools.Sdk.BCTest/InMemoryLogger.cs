using System;
using System.Collections.Concurrent;
using System.Text;
using Microsoft.Extensions.Logging;

namespace commercetools.Sdk.BCTest
{
    public class InMemoryLogger : ILogger
    {
        private static ConcurrentQueue<string> LogMessages { get; set; }

        public void Log<TState>(
            LogLevel logLevel, EventId eventId,
            TState state, Exception exception,
            Func<TState, Exception, string> formatter)
        {
            if (LogMessages == null)
            {
                LogMessages = new ConcurrentQueue<string>();
            }
            if (formatter != null)
            {
                LogMessages.Enqueue((formatter(state, exception)));
            }
        }

        public bool IsEnabled(LogLevel logLevel)
        {
            return true;
        }

        public IDisposable BeginScope<TState>(TState state)
        {
            return null;
        }

        public static string GetLogMessages()
        {
            if (LogMessages == null)
                return "";

            var stringBuilder = new StringBuilder();
            foreach (var item in LogMessages)
            {
                stringBuilder.AppendLine(item);
            }

            return stringBuilder.ToString();
        }
    }
}