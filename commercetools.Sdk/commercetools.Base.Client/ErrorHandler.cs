using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using commercetools.Base.Serialization;

namespace commercetools.Base.Client
{
    public class ErrorHandler : DelegatingHandler
    {
        private Func<HttpResponseMessage, Object> errorResponseBodyFactory;

        public ErrorHandler(Func<HttpResponseMessage, Object> errorResponseBodyFactory)
        {
            this.errorResponseBodyFactory = errorResponseBodyFactory;
        }

        protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            var response = await base.SendAsync(request, cancellationToken).ConfigureAwait(false);
            
            if (response != null && !response.IsSuccessStatusCode)
            {
                var exception = ExceptionFactory.Create(request, response, errorResponseBodyFactory);
                throw exception;
            }

            return response;
        }
    }
}