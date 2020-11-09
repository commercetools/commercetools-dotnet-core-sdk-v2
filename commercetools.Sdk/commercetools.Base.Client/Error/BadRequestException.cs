namespace commercetools.Base.Client.Error
{
    public class BadRequestException : ApiClientException
    {
        public BadRequestException(int statusCode, string body, ApiHttpHeaders headers, string message)
            : base(statusCode, body, headers, message)
        {
        }
    }
}