using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace commercetools.Base.Client.Middlewares
{
    public abstract class DelegatingMiddleware : Middleware
    {
        public Middleware InnerMiddleware { get; set; }

        protected internal override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request,
            CancellationToken cancellationToken)
        {
            return InnerMiddleware.SendAsync(request, cancellationToken);
        }
    }
}