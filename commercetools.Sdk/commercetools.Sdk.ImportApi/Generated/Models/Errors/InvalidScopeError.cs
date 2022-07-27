namespace commercetools.Sdk.ImportApi.Models.Errors
{

    public partial class InvalidScopeError : IInvalidScopeError
    {
        public string Code { get; set; }

        public string Message { get; set; }
        public InvalidScopeError()
        {
            this.Code = "invalid_scope";
        }
    }
}
