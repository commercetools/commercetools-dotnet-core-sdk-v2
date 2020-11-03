namespace commercetools.Base.Client.Error
{
    public class ApiClientException : ApiHttpException
    {
        public ApiClientException(int statusCode, string body, ApiHttpHeaders headers, string message)
            : base(statusCode, body, headers, message)
        {
        }
    }
}