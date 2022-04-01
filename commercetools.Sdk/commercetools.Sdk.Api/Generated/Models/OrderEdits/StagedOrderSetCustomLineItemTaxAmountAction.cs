using commercetools.Sdk.Api.Models.Carts;


namespace commercetools.Sdk.Api.Models.OrderEdits
{
    public partial class StagedOrderSetCustomLineItemTaxAmountAction : IStagedOrderSetCustomLineItemTaxAmountAction
    {
        public string Action { get; set; }

        public string CustomLineItemId { get; set; }

        public IExternalTaxAmountDraft ExternalTaxAmount { get; set; }
        public StagedOrderSetCustomLineItemTaxAmountAction()
        {
            this.Action = "setCustomLineItemTaxAmount";
        }
    }
}
