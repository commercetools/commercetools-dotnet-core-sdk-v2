

namespace commercetools.Sdk.CheckoutApi.Models.Responses
{

    public partial class CheckoutLoaded : ICheckoutLoaded
    {
        public string Code { get; set; }

        public string Severity { get; set; }

        public string Message { get; set; }

        public string CorrelationId { get; set; }
        public CheckoutLoaded()
        {
            this.Code = "checkout_loaded";
        }
    }
}
