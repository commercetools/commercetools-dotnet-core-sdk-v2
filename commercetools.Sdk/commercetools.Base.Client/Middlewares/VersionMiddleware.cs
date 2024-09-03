using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace commercetools.Base.Client.Middlewares
{
    public class VersionMiddleware: DelegatingMiddleware
    {
        private readonly Version _httpVersion;

        public VersionMiddleware(Version httpVersion)
        {
            this._httpVersion = httpVersion;
        }
        
        protected internal override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            request.Version = _httpVersion;
            return await base.SendAsync(request, cancellationToken).ConfigureAwait(false);
        }

    }
}