using System.Collections.Generic;


namespace commercetools.Api.Models.ShoppingLists
{
    public partial class ShoppingListChangeTextLineItemsOrderAction : IShoppingListChangeTextLineItemsOrderAction
    {
        public string Action { get; set; }

        public List<string> TextLineItemOrder { get; set; }
        public ShoppingListChangeTextLineItemsOrderAction()
        {
            this.Action = "changeTextLineItemsOrder";
        }
    }
}
