

namespace commercetools.Sdk.CheckoutApi.Models.Responses
{

    public partial class ShippingMethodDoesNotMatchCart : IShippingMethodDoesNotMatchCart
    {
        public string Code { get; set; }

        public string Severity { get; set; }

        public string Message { get; set; }

        public string CorrelationId { get; set; }
        public ShippingMethodDoesNotMatchCart()
        {
            this.Code = "shipping_method_does_not_match_cart";
        }
    }
}
