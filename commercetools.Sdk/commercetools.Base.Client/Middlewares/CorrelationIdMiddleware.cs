using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace commercetools.Base.Client.Middlewares
{
    public class CorrelationIdMiddleware : DelegatingMiddleware
    {
        private readonly ICorrelationIdProvider correlationIdProvider;

        public CorrelationIdMiddleware(ICorrelationIdProvider correlationIdProvider)
        {
            this.correlationIdProvider = correlationIdProvider;
        }

        protected internal override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            if (!request.Headers.Contains(ApiHttpHeaders.X_CORRELATION_ID))
            {
                request.Headers.Add(ApiHttpHeaders.X_CORRELATION_ID, this.correlationIdProvider.CorrelationId);
            }
            return await base.SendAsync(request, cancellationToken).ConfigureAwait(false);
        }
    }
}
