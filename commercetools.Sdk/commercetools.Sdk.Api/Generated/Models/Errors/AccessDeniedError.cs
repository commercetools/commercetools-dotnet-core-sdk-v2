namespace commercetools.Sdk.Api.Models.Errors
{

    public partial class AccessDeniedError : IAccessDeniedError
    {
        public string Code { get; set; }

        public string Message { get; set; }
        public AccessDeniedError()
        {
            this.Code = "access_denied";
        }
    }
}
