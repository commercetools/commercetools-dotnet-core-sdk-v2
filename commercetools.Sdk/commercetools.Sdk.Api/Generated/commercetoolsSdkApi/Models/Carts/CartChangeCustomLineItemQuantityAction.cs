

namespace commercetools.Sdk.Api.Models.Carts
{

    public partial class CartChangeCustomLineItemQuantityAction : ICartChangeCustomLineItemQuantityAction
    {
        public string Action { get; set; }

        public string CustomLineItemId { get; set; }

        public string CustomLineItemKey { get; set; }

        public long Quantity { get; set; }
        public CartChangeCustomLineItemQuantityAction()
        {
            this.Action = "changeCustomLineItemQuantity";
        }
    }
}
