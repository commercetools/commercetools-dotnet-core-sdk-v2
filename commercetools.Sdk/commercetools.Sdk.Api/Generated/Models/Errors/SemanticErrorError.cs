namespace commercetools.Sdk.Api.Models.Errors
{

    public partial class SemanticErrorError : ISemanticErrorError
    {
        public string Code { get; set; }

        public string Message { get; set; }
        public SemanticErrorError()
        {
            this.Code = "SemanticError";
        }
    }
}
