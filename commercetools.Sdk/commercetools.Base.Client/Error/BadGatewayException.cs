namespace commercetools.Base.Client.Error
{
    public class BadGatewayException : ApiServerException
    {
        public BadGatewayException(int statusCode, string body, ApiHttpHeaders headers, string message)
            : base(statusCode, body, headers, message)
        {
        }
    }
}