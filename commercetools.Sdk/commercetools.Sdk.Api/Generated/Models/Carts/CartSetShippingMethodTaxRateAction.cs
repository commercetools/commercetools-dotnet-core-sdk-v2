namespace commercetools.Api.Models.Carts
{
    public partial class CartSetShippingMethodTaxRateAction : ICartSetShippingMethodTaxRateAction
    {
        public string Action { get; set; }

        public IExternalTaxRateDraft ExternalTaxRate { get; set; }
        public CartSetShippingMethodTaxRateAction()
        {
            this.Action = "setShippingMethodTaxRate";
        }
    }
}
