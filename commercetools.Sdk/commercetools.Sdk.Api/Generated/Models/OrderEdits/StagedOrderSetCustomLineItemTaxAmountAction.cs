using commercetools.Sdk.Api.Models.Carts;


namespace commercetools.Sdk.Api.Models.OrderEdits
{

    public partial class StagedOrderSetCustomLineItemTaxAmountAction : IStagedOrderSetCustomLineItemTaxAmountAction
    {
        public string Action { get; set; }

        public string CustomLineItemId { get; set; }

        public string CustomLineItemKey { get; set; }

        public IExternalTaxAmountDraft ExternalTaxAmount { get; set; }

        public string ShippingKey { get; set; }
        public StagedOrderSetCustomLineItemTaxAmountAction()
        {
            this.Action = "setCustomLineItemTaxAmount";
        }
    }
}
