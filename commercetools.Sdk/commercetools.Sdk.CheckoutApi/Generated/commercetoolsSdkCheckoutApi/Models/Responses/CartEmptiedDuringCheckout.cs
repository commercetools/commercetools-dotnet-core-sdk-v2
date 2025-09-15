using System;

namespace commercetools.Sdk.CheckoutApi.Models.Responses
{

    public partial class CartEmptiedDuringCheckout : ICartEmptiedDuringCheckout
    {
        public string Code { get; set; }

        public string Severity { get; set; }

        public string Message { get; set; }

        public string CorrelationId { get; set; }

        public Object Payload { get; set; }
        public CartEmptiedDuringCheckout()
        {
            this.Code = "cart_emptied_during_checkout";
        }
    }
}
