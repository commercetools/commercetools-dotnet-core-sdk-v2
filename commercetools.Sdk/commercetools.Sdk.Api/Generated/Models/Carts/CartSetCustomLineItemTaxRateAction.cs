namespace commercetools.Sdk.Api.Models.Carts
{
    public partial class CartSetCustomLineItemTaxRateAction : ICartSetCustomLineItemTaxRateAction
    {
        public string Action { get; set; }

        public string CustomLineItemId { get; set; }

        public IExternalTaxRateDraft ExternalTaxRate { get; set; }
        public CartSetCustomLineItemTaxRateAction()
        {
            this.Action = "setCustomLineItemTaxRate";
        }
    }
}
