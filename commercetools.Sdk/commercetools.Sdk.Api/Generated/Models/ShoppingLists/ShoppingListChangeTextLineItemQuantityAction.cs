namespace commercetools.Sdk.Api.Models.ShoppingLists
{

    public partial class ShoppingListChangeTextLineItemQuantityAction : IShoppingListChangeTextLineItemQuantityAction
    {
        public string Action { get; set; }

        public string TextLineItemId { get; set; }

        public long Quantity { get; set; }
        public ShoppingListChangeTextLineItemQuantityAction()
        {
            this.Action = "changeTextLineItemQuantity";
        }
    }
}
