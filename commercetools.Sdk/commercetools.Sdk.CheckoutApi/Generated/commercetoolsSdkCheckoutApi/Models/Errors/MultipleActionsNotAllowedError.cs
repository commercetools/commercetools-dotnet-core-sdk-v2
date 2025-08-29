

namespace commercetools.Sdk.CheckoutApi.Models.Errors
{

    public partial class MultipleActionsNotAllowedError : IMultipleActionsNotAllowedError
    {
        public string Code { get; set; }

        public string Message { get; set; }
        public MultipleActionsNotAllowedError()
        {
            this.Code = "MultipleActionsNotAllowed";
        }
    }
}
