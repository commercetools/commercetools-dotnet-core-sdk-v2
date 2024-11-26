using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace commercetools.Base.Client
{
    public class ErrorHandler : DelegatingHandler
    {
        private readonly Func<HttpResponseMessage, object> _errorResponseBodyMapper;
        
        public ErrorHandler(Func<HttpResponseMessage, object> errorResponseBodyMapper)
        {
            this._errorResponseBodyMapper = errorResponseBodyMapper;
        }

        protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            var response = await base.SendAsync(request, cancellationToken).ConfigureAwait(false);

            if (response is { IsSuccessStatusCode: false })
            {
                var exception = ExceptionFactory.Create(request, response, _errorResponseBodyMapper);
                throw exception;
            }

            return response;
        }
    }
}