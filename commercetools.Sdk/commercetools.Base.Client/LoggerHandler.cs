using System;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;

namespace commercetools.Base.Client
{
    public class LoggerHandler : DelegatingHandler
    {
        private readonly ILoggerFactory _loggerFactory;

        private readonly IHttpLogger _httpLogger;

        private readonly ILoggerHandlerOptions _loggerHandlerOptions;

        public LoggerHandler(ILoggerFactory loggerFactory, IHttpLogger httpLogger = null, ILoggerHandlerOptions options = null)
        {
            _loggerFactory = loggerFactory;
            _httpLogger = httpLogger ?? new DefaultHttpLogger();
            _loggerHandlerOptions = options ?? new LoggerHandlerOptions();
        }

        protected override async Task<HttpResponseMessage> SendAsync(
            HttpRequestMessage request,
            CancellationToken cancellationToken)
        {
            var logger = _loggerFactory.CreateLogger("commercetoolsLoggerHandler");

            if (request == null)
            {
                throw new ArgumentNullException(nameof(request));
            }

            _httpLogger.Log(logger, LogLevel.Debug, request);
            await _httpLogger.LogRequestBody(logger, LogLevel.Trace, request).ConfigureAwait(false);
            var watch = Stopwatch.StartNew();
            try
            {
                var response = await base.SendAsync(request, cancellationToken).ConfigureAwait(false);
                watch.Stop();

                _httpLogger.Log(logger, (int)response.StatusCode < 400 ? _loggerHandlerOptions.ResponseLogEvent : _loggerHandlerOptions.DefaultExceptionLogEvent, request, response, watch.ElapsedMilliseconds);
                await _httpLogger.LogResponseBody(logger, LogLevel.Trace, request, response, watch.ElapsedMilliseconds);

                return response;
            }
            catch (ApiHttpException e)
            {
                watch.Stop();
                var defaultLevel = _loggerHandlerOptions.DefaultExceptionLogEvent;
                var exceptionLevel = _loggerHandlerOptions.ExceptionLogEvents
                    .Where(pair => pair.Key.IsInstanceOfType(e))
                    .Select(pair => pair.Value)
                    .ToArray();
                _httpLogger.Log(logger, exceptionLevel.Any() ? exceptionLevel.First() : defaultLevel, request, e, watch.ElapsedMilliseconds);
                throw;
            }
        }
    }
}