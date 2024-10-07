

namespace commercetools.Sdk.Api.Models.ShoppingLists
{

    public partial class ShoppingListChangeLineItemQuantityAction : IShoppingListChangeLineItemQuantityAction
    {
        public string Action { get; set; }

        public string LineItemId { get; set; }

        public string LineItemKey { get; set; }

        public long Quantity { get; set; }
        public ShoppingListChangeLineItemQuantityAction()
        {
            this.Action = "changeLineItemQuantity";
        }
    }
}
