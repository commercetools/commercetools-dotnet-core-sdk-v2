namespace commercetools.Sdk.Api.Models.Carts
{

    public partial class CartSetShippingRateInputAction : ICartSetShippingRateInputAction
    {
        public string Action { get; set; }

        public IShippingRateInputDraft ShippingRateInput { get; set; }
        public CartSetShippingRateInputAction()
        {
            this.Action = "setShippingRateInput";
        }
    }
}
