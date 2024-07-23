using System.Collections.Generic;
using System.Linq;


namespace commercetools.Sdk.Api.Models.ShoppingLists
{

    public partial class ShoppingListChangeTextLineItemsOrderAction : IShoppingListChangeTextLineItemsOrderAction
    {
        public string Action { get; set; }

        public IList<string> TextLineItemOrder { get; set; }
        public IEnumerable<string> TextLineItemOrderEnumerable { set => TextLineItemOrder = value.ToList(); }

        public ShoppingListChangeTextLineItemsOrderAction()
        {
            this.Action = "changeTextLineItemsOrder";
        }
    }
}
