using System;

namespace commercetools.Base.Client
{
    public class ApiHttpException : Exception
    {
        public int StatusCode { get; set; }
        
        public string Body { get; set; }

        public ApiHttpHeaders Headers { get; set; }

        public ApiHttpException(int statusCode, string body, ApiHttpHeaders headers)
        {
            Initialize(statusCode, body, headers);
        }

        public ApiHttpException(int statusCode, string body, ApiHttpHeaders headers, string message)
            : base(message)
        {
            Initialize(statusCode, body, headers);
        }

        private void Initialize(int statusCode, string body, ApiHttpHeaders headers)
        {
            this.StatusCode = statusCode;
            this.Body = body;
            this.Headers = headers;
        }
    }
}