

namespace commercetools.Sdk.CheckoutApi.Models.Errors
{

    public partial class InvalidOperationError : IInvalidOperationError
    {
        public string Code { get; set; }

        public string Message { get; set; }
        public InvalidOperationError()
        {
            this.Code = "InvalidOperation";
        }
    }
}
