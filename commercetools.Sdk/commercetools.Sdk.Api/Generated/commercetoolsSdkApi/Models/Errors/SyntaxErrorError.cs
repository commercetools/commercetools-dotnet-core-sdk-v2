namespace commercetools.Sdk.Api.Models.Errors
{

    public partial class SyntaxErrorError : ISyntaxErrorError
    {
        public string Code { get; set; }

        public string Message { get; set; }
        public SyntaxErrorError()
        {
            this.Code = "SyntaxError";
        }
    }
}
