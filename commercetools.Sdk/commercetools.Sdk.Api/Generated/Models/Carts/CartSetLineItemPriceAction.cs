using commercetools.Api.Models.Common;


namespace commercetools.Api.Models.Carts
{
    public partial class CartSetLineItemPriceAction : ICartSetLineItemPriceAction
    {
        public string Action { get; set; }

        public string LineItemId { get; set; }

        public IMoney ExternalPrice { get; set; }
        public CartSetLineItemPriceAction()
        {
            this.Action = "setLineItemPrice";
        }
    }
}
