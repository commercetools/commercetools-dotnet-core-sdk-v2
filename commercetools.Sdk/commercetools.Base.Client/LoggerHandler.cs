using System;
using System.Diagnostics;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using commercetools.Base.Client.Domain;
using Microsoft.Extensions.Logging;

namespace commercetools.Base.Client
{
    public class LoggerHandler : DelegatingHandler
    {
        private readonly ILoggerFactory _loggerFactory;

        private readonly IHttpLogger _httpLogger;

        public LoggerHandler(ILoggerFactory loggerFactory, IHttpLogger httpLogger = null)
        {
            _loggerFactory = loggerFactory;
            _httpLogger = httpLogger ?? new DefaultHttpLogger();
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

            _httpLogger.Debug(logger, request);
            await _httpLogger.Trace(logger, request).ConfigureAwait(false);
            var watch = Stopwatch.StartNew();
            try
            {
                var response = await base.SendAsync(request, cancellationToken).ConfigureAwait(false);
                watch.Stop();
                
                _httpLogger.Log(logger, (int)response.StatusCode < 400 ? LogLevel.Information : LogLevel.Error, request, response, watch.ElapsedMilliseconds);
                await _httpLogger.Trace(logger, request, response);
                
                return response;
            }
            catch (ApiHttpException e)
            {
                watch.Stop();
                _httpLogger.Error(logger, request, e, watch.ElapsedMilliseconds);
                throw;
            }
        }
    }
}