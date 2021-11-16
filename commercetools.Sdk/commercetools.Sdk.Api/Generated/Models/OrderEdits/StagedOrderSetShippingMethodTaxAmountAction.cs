using commercetools.Api.Models.Carts;


namespace commercetools.Api.Models.OrderEdits
{
    public partial class StagedOrderSetShippingMethodTaxAmountAction : IStagedOrderSetShippingMethodTaxAmountAction
    {
        public string Action { get; set; }

        public IExternalTaxAmountDraft ExternalTaxAmount { get; set; }
        public StagedOrderSetShippingMethodTaxAmountAction()
        {
            this.Action = "setShippingMethodTaxAmount";
        }
    }
}
