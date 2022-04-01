using commercetools.Sdk.Api.Models.Carts;
using commercetools.Sdk.Api.Models.ShippingMethods;


namespace commercetools.Sdk.Api.Models.OrderEdits
{
    public partial class StagedOrderSetShippingMethodAction : IStagedOrderSetShippingMethodAction
    {
        public string Action { get; set; }

        public IShippingMethodResourceIdentifier ShippingMethod { get; set; }

        public IExternalTaxRateDraft ExternalTaxRate { get; set; }
        public StagedOrderSetShippingMethodAction()
        {
            this.Action = "setShippingMethod";
        }
    }
}
