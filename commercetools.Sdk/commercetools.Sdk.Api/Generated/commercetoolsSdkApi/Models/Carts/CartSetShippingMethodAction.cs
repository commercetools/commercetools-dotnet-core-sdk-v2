using commercetools.Sdk.Api.Models.ShippingMethods;


namespace commercetools.Sdk.Api.Models.Carts
{

    public partial class CartSetShippingMethodAction : ICartSetShippingMethodAction
    {
        public string Action { get; set; }

        public IShippingMethodResourceIdentifier ShippingMethod { get; set; }

        public IExternalTaxRateDraft ExternalTaxRate { get; set; }
        public CartSetShippingMethodAction()
        {
            this.Action = "setShippingMethod";
        }
    }
}
