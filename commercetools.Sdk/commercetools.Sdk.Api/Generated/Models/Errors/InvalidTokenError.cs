namespace commercetools.Sdk.Api.Models.Errors
{
    public partial class InvalidTokenError : IInvalidTokenError
    {
        public string Code { get; set; }

        public string Message { get; set; }
        public InvalidTokenError()
        {
            this.Code = "invalid_token";
        }
    }
}
