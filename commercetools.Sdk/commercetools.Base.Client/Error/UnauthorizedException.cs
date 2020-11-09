namespace commercetools.Base.Client.Error
{
    public class UnauthorizedException : ApiClientException
    {
        public UnauthorizedException(int statusCode, string body, ApiHttpHeaders headers, string message)
            : base(statusCode, body, headers, message)
        {
        }
    }
}