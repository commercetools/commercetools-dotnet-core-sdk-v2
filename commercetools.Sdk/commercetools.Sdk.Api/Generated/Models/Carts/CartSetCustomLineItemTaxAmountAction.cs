namespace commercetools.Sdk.Api.Models.Carts
{

    public partial class CartSetCustomLineItemTaxAmountAction : ICartSetCustomLineItemTaxAmountAction
    {
        public string Action { get; set; }

        public string CustomLineItemId { get; set; }

        public string CustomLineItemKey { get; set; }

        public IExternalTaxAmountDraft ExternalTaxAmount { get; set; }
        public CartSetCustomLineItemTaxAmountAction()
        {
            this.Action = "setCustomLineItemTaxAmount";
        }
    }
}
