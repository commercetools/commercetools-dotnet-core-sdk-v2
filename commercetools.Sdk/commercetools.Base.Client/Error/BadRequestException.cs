using System;

namespace commercetools.Base.Client.Error
{
    public class BadRequestException : ApiClientException
    {
        public BadRequestException(int statusCode, string body, ApiHttpHeaders headers, Object responseBody, string message)
            : base(statusCode, body, headers, responseBody, message)
        {
        }
    }
}