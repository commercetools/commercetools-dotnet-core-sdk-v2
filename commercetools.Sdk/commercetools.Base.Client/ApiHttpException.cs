using System;

namespace commercetools.Base.Client
{
    public class ApiHttpException : Exception
    {
        public int StatusCode { get; set; }
        
        public string Body { get; set; }
        
        public Object ResponseBody { get; private set; }

        public ApiHttpHeaders Headers { get; set; }

        public ApiHttpException(int statusCode, string body, ApiHttpHeaders headers, string message)
            : base(message)
        {
            Initialize(statusCode, body, headers, null);
        }
        
        public ApiHttpException(int statusCode, string body, ApiHttpHeaders headers, Object responseBody, string message)
            : base(message)
        {
            Initialize(statusCode, body, headers, responseBody);
        }

        private void Initialize(int statusCode, string body, ApiHttpHeaders headers, Object responseBody)
        {
            this.StatusCode = statusCode;
            this.Body = body;
            this.Headers = headers;
            this.ResponseBody = responseBody;
        }
    }
}