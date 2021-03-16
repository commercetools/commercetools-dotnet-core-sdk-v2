using System;

namespace commercetools.Base.Client.Error
{
    public class ApiClientException : ApiHttpException
    {
        public ApiClientException(int statusCode, string body, ApiHttpHeaders headers, Object responseBody, string message)
            : base(statusCode, body, headers, responseBody, message)
        {
        }
    }
}