namespace commercetools.Base.Client.Error
{
    public class ApiServerException : ApiHttpException
    {
        public ApiServerException(int statusCode, string body, ApiHttpHeaders headers, string message)
            : base(statusCode, body, headers, message)
        {
        }
    }
}