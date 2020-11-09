namespace commercetools.Base.Client.Error
{
    public class GatewayTimeoutException : ApiServerException
    {
        public GatewayTimeoutException(int statusCode, string body, ApiHttpHeaders headers, string message)
            : base(statusCode, body, headers, message)
        {
        }
    }
}