using System;

namespace commercetools.Base.Client.Error
{
    public class InternalServerErrorException : ApiServerException
    {
        public InternalServerErrorException(int statusCode, string body, ApiHttpHeaders headers, Object responseBody, string message)
            : base(statusCode, body, headers, responseBody, message)
        {
        }
    }
}