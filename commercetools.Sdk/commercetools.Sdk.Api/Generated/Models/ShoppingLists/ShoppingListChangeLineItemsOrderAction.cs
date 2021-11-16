using System.Collections.Generic;


namespace commercetools.Api.Models.ShoppingLists
{
    public partial class ShoppingListChangeLineItemsOrderAction : IShoppingListChangeLineItemsOrderAction
    {
        public string Action { get; set;}
        
        public List<string> LineItemOrder { get; set;}
        public ShoppingListChangeLineItemsOrderAction()
        { 
           this.Action = "changeLineItemsOrder";
        }
    }
}
