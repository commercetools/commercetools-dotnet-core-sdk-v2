using commercetools.Sdk.Api.Models.Common;


namespace commercetools.Sdk.Api.Models.Carts
{

    public partial class CartSetLineItemPriceAction : ICartSetLineItemPriceAction
    {
        public string Action { get; set; }

        public string LineItemId { get; set; }

        public string LineItemKey { get; set; }

        public IMoney ExternalPrice { get; set; }
        public CartSetLineItemPriceAction()
        {
            this.Action = "setLineItemPrice";
        }
    }
}
