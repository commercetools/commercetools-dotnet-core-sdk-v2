using System;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace commercetools.Base.Client;

public class HeadNotFoundHandler : DelegatingHandler
{
    private readonly Func<HttpResponseMessage, object> _errorResponseBodyMapper;

    public HeadNotFoundHandler(Func<HttpResponseMessage, object> errorResponseBodyMapper)
    {
        this._errorResponseBodyMapper = errorResponseBodyMapper;
    }

    protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
    {
        var response = await base.SendAsync(request, cancellationToken).ConfigureAwait(false);

        if (response.StatusCode == HttpStatusCode.NotFound && response.RequestMessage!.Method == HttpMethod.Head)
        {

        }

        return response;
    }
}