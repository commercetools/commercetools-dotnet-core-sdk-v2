using commercetools.Sdk.Api.Models.Carts;


namespace commercetools.Sdk.Api.Models.OrderEdits
{

    public partial class StagedOrderSetShippingMethodTaxAmountAction : IStagedOrderSetShippingMethodTaxAmountAction
    {
        public string Action { get; set; }

        public string ShippingKey { get; set; }

        public IExternalTaxAmountDraft ExternalTaxAmount { get; set; }
        public StagedOrderSetShippingMethodTaxAmountAction()
        {
            this.Action = "setShippingMethodTaxAmount";
        }
    }
}
