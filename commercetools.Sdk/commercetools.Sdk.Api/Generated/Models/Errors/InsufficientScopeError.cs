namespace commercetools.Sdk.Api.Models.Errors
{

    public partial class InsufficientScopeError : IInsufficientScopeError
    {
        public string Code { get; set; }

        public string Message { get; set; }
        public InsufficientScopeError()
        {
            this.Code = "insufficient_scope";
        }
    }
}
