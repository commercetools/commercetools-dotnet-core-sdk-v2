namespace commercetools.Base.Client.Error
{
    public class InternalServerErrorException : ApiServerException
    {
        public InternalServerErrorException(int statusCode, string body, ApiHttpHeaders headers, string message)
            : base(statusCode, body, headers, message)
        {
        }
    }
}