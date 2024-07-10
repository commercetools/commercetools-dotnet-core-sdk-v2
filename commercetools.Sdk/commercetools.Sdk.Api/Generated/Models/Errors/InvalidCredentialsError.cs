namespace commercetools.Sdk.Api.Models.Errors
{

    public partial class InvalidCredentialsError : IInvalidCredentialsError
    {
        public string Code { get; set; }

        public string Message { get; set; }
        public InvalidCredentialsError()
        {
            this.Code = "InvalidCredentials";
        }
    }
}
