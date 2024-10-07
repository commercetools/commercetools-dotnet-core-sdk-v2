

namespace commercetools.Sdk.Api.Models.Carts
{

    public partial class CartSetShippingMethodTaxAmountAction : ICartSetShippingMethodTaxAmountAction
    {
        public string Action { get; set; }

        public string ShippingKey { get; set; }

        public IExternalTaxAmountDraft ExternalTaxAmount { get; set; }
        public CartSetShippingMethodTaxAmountAction()
        {
            this.Action = "setShippingMethodTaxAmount";
        }
    }
}
