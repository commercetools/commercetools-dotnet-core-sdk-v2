using System.Net;
using System.Net.Http.Headers;

namespace commercetools.Base.Client
{
    public interface IApiResponse<out T>
    {
        HttpStatusCode StatusCode { get; }
        string ReasonPhrase { get; }
        HttpHeaders HttpHeaders { get; }
        T Body { get; }
    }
}