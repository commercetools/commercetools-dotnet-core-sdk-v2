using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace commercetools.Base.Client
{
    public class ErrorHandler : DelegatingHandler
    {
        private Func<HttpResponseMessage, Object> errorResponseBodyMapper;

        public ErrorHandler(Func<HttpResponseMessage, Object> errorResponseBodyMapper)
        {
            this.errorResponseBodyMapper = errorResponseBodyMapper;
        }

        protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            var response = await base.SendAsync(request, cancellationToken).ConfigureAwait(false);

            if (response != null && !response.IsSuccessStatusCode)
            {
                var exception = ExceptionFactory.Create(request, response, errorResponseBodyMapper);
                throw exception;
            }

            return response;
        }
    }
}