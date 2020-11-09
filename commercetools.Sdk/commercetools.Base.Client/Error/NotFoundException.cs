namespace commercetools.Base.Client.Error
{
    public class NotFoundException : ApiClientException
    {
        public NotFoundException(int statusCode, string body, ApiHttpHeaders headers, string message)
            : base(statusCode, body, headers, message)
        {
        }
    }
}