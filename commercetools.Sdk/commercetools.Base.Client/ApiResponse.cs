using System.Net;
using System.Net.Http.Headers;

namespace commercetools.Base.Client
{
    public class ApiResponse<T> : IApiResponse<T>
    {
        public HttpStatusCode StatusCode { get; }
        public string ReasonPhrase { get; }
        public HttpHeaders HttpHeaders { get; }
        public T Body { get; }

        public ApiResponse(HttpStatusCode statusCode, string reasonPhrase, HttpHeaders httpHeaders, T body)
        {
            StatusCode = statusCode;
            ReasonPhrase = reasonPhrase;
            HttpHeaders = httpHeaders;
            Body = body;
        }
    }
}