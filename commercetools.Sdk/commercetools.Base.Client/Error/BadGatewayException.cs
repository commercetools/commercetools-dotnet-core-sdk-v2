using System;

namespace commercetools.Base.Client.Error
{
    public class BadGatewayException : ApiServerException
    {
        public BadGatewayException(int statusCode, string body, ApiHttpHeaders headers, Object responseBody, string message)
            : base(statusCode, body, headers, responseBody, message)
        {
        }
    }
}