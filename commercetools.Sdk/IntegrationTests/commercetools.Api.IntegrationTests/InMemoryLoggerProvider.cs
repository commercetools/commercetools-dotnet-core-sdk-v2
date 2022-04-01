using System.Collections.Concurrent;
using System.Linq;
using Microsoft.Extensions.Logging;

namespace commercetools.Sdk.Api.IntegrationTests
{
    public class InMemoryLoggerProvider : ILoggerProvider
    {
        private readonly ConcurrentDictionary<string, ILogger> _loggers;

        public InMemoryLoggerProvider()
        {
            _loggers = new ConcurrentDictionary<string, ILogger>();
        }

        public void Dispose()
        {
        }

        public ILogger CreateLogger(string categoryName)
        {
            return _loggers.GetOrAdd(categoryName, new InMemoryLogger());
        }

        public InMemoryLogger GetLogger()
        {
            if (_loggers == null || _loggers.Count == 0)
                return null;
            return _loggers.FirstOrDefault().Value as InMemoryLogger;
        }
    }
}