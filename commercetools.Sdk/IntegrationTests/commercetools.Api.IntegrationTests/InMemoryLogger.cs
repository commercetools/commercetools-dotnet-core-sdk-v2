using System;
using System.Collections.Concurrent;
using System.Text;
using Microsoft.Extensions.Logging;

namespace commercetools.Api.IntegrationTests
{
    public class InMemoryLogger : ILogger
    {
        private string _categoryName;

        public InMemoryLogger(string categoryName)
        {
            this._categoryName = categoryName;
        }

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

        public static void Clear()
        {
            LogMessages?.Clear();
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