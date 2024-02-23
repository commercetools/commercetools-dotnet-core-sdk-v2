using commercetools.Sdk.Api.Models.Carts;
using commercetools.Sdk.Api.Models.ShippingMethods;


namespace commercetools.Sdk.Api.Models.Me
{

    public partial class MyCartSetShippingMethodAction : IMyCartSetShippingMethodAction
    {
        public string Action { get; set; }

        public IShippingMethodResourceIdentifier ShippingMethod { get; set; }

        public IExternalTaxRateDraft ExternalTaxRate { get; set; }
        public MyCartSetShippingMethodAction()
        {
            this.Action = "setShippingMethod";
        }
    }
}
