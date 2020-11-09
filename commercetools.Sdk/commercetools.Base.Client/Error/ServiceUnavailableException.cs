namespace commercetools.Base.Client.Error
{
    public class ServiceUnavailableException : ApiServerException
    {
        public ServiceUnavailableException(int statusCode, string body, ApiHttpHeaders headers, string message)
            : base(statusCode, body, headers, message)
        {
        }
    }
}