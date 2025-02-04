using System;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace commercetools.Base.Client
{
    public class ErrorHandler : DelegatingHandler
    {
        private readonly Func<HttpResponseMessage, object> _errorResponseBodyMapper;

        private readonly bool _notFoundReturnsEmpty;
        private readonly bool _headNotFoundReturnsEmpty;

        public ErrorHandler(Func<HttpResponseMessage, object> errorResponseBodyMapper, bool notFoundReturnsEmpty = false, bool headNotFoundReturnsEmpty = false)
        {
            this._errorResponseBodyMapper = errorResponseBodyMapper;
            this._notFoundReturnsEmpty = notFoundReturnsEmpty;
            this._headNotFoundReturnsEmpty = headNotFoundReturnsEmpty;
        }

        protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            var response = await base.SendAsync(request, cancellationToken).ConfigureAwait(false);

            if (response is { IsSuccessStatusCode: true })
                return response;

            if (response.StatusCode == HttpStatusCode.NotFound && (_notFoundReturnsEmpty || (_headNotFoundReturnsEmpty && request.Method == HttpMethod.Head) ))
            {
                response.Content = new EmptyContent();
                return response;
            }

            throw ExceptionFactory.Create(request, response, _errorResponseBodyMapper);
        }
    }
}