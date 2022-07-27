using commercetools.Sdk.Api.Models.Carts;


namespace commercetools.Sdk.Api.Models.OrderEdits
{

    public partial class StagedOrderSetShippingMethodTaxRateAction : IStagedOrderSetShippingMethodTaxRateAction
    {
        public string Action { get; set; }

        public IExternalTaxRateDraft ExternalTaxRate { get; set; }
        public StagedOrderSetShippingMethodTaxRateAction()
        {
            this.Action = "setShippingMethodTaxRate";
        }
    }
}
