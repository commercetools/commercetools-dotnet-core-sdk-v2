namespace commercetools.Base.Client.Error
{
    public class ConcurrentModificationException : ApiClientException
    {
        public ConcurrentModificationException(int statusCode, string body, ApiHttpHeaders headers, string message)
            : base(statusCode, body, headers, message)
        {
        }
    }
}