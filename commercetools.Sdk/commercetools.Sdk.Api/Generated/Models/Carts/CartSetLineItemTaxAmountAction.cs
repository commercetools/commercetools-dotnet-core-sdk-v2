namespace commercetools.Api.Models.Carts
{
    public partial class CartSetLineItemTaxAmountAction : ICartSetLineItemTaxAmountAction
    {
        public string Action { get; set; }

        public string LineItemId { get; set; }

        public IExternalTaxAmountDraft ExternalTaxAmount { get; set; }
        public CartSetLineItemTaxAmountAction()
        {
            this.Action = "setLineItemTaxAmount";
        }
    }
}
