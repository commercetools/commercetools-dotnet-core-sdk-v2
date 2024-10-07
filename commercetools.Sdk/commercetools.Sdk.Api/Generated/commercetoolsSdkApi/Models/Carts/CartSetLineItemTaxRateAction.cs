

namespace commercetools.Sdk.Api.Models.Carts
{

    public partial class CartSetLineItemTaxRateAction : ICartSetLineItemTaxRateAction
    {
        public string Action { get; set; }

        public string LineItemId { get; set; }

        public string LineItemKey { get; set; }

        public IExternalTaxRateDraft ExternalTaxRate { get; set; }

        public string ShippingKey { get; set; }
        public CartSetLineItemTaxRateAction()
        {
            this.Action = "setLineItemTaxRate";
        }
    }
}
