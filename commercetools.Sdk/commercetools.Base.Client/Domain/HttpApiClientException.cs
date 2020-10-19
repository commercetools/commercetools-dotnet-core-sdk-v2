using System;

namespace commercetools.Base.Client.Domain
{
    public class HttpApiClientException : Exception
    {
        public int StatusCode { get; set; }

        public HttpApiClientException(string message) : base(message)
        {

        }

        public HttpApiClientException(string message, int statusCode, string body = null) : this(message)
        {
            StatusCode = statusCode;
        }
    }
}
