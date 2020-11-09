namespace commercetools.Base.Client.Error
{
    public class ForbiddenException : ApiClientException
    {
        public ForbiddenException(int statusCode, string body, ApiHttpHeaders headers, string message)
            : base(statusCode, body, headers, message)
        {
        }
    }
}