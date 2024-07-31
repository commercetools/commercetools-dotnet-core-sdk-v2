

namespace commercetools.Sdk.Api.Models.ShoppingLists
{

    public partial class ShoppingListRemoveTextLineItemAction : IShoppingListRemoveTextLineItemAction
    {
        public string Action { get; set; }

        public string TextLineItemId { get; set; }

        public string TextLineItemKey { get; set; }

        public long? Quantity { get; set; }
        public ShoppingListRemoveTextLineItemAction()
        {
            this.Action = "removeTextLineItem";
        }
    }
}
