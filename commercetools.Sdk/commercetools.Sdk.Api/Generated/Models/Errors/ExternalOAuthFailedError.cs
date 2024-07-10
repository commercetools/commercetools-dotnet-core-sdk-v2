namespace commercetools.Sdk.Api.Models.Errors
{

    public partial class ExternalOAuthFailedError : IExternalOAuthFailedError
    {
        public string Code { get; set; }

        public string Message { get; set; }
        public ExternalOAuthFailedError()
        {
            this.Code = "ExternalOAuthFailed";
        }
    }
}
