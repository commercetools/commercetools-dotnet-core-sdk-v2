using commercetools.Api.Models.Carts;
using commercetools.Api.Models.ShippingMethods;


namespace commercetools.Api.Models.OrderEdits
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
