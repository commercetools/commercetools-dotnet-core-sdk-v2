namespace commercetools.Sdk.Api.Models.Errors
{
    public partial class RequiredFieldError : IRequiredFieldError
    {
        public string Code { get; set; }

        public string Message { get; set; }

        public string Field { get; set; }
        public RequiredFieldError()
        {
            this.Code = "RequiredField";
        }
    }
}
