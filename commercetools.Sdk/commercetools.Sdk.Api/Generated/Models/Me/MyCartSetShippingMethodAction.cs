using commercetools.Api.Models.Carts;
using commercetools.Api.Models.ShippingMethods;


namespace commercetools.Api.Models.Me
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
