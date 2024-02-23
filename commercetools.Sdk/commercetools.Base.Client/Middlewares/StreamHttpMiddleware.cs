using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace commercetools.Base.Client.Middlewares
{
    public class StreamHttpMiddleware : DelegatingMiddleware
    {
        private readonly HttpClient client;

        public StreamHttpMiddleware(HttpClient client)
        {
            this.client = client;
        }


        protected internal override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            return await client.SendAsync(request, HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
        }
    }
}