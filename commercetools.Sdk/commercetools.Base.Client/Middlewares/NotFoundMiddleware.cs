using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using commercetools.Base.Client.Error;

namespace commercetools.Base.Client.Middlewares;

public class NotFoundMiddleware: DelegatingMiddleware
{
    protected internal override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
    {
        try
        {
            return await base.SendAsync(request, cancellationToken).ConfigureAwait(false);
        }
        catch (NotFoundException exception)
        {
            return new HttpResponseMessage()
            {
                StatusCode = HttpStatusCode.NotFound,
                Content = new EmptyContent(),
                ReasonPhrase = exception.Message,
                RequestMessage = request,
            };
        }
    }
}