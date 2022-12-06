using System.Collections.Generic;
using System.Linq;


namespace commercetools.Sdk.Api.Models.ShoppingLists
{

    public partial class ShoppingListChangeLineItemsOrderAction : IShoppingListChangeLineItemsOrderAction
    {
        public string Action { get; set; }

        public IList<string> LineItemOrder { get; set; }
        public IEnumerable<string> LineItemOrderEnumerable { set => LineItemOrder = value.ToList(); }

        public ShoppingListChangeLineItemsOrderAction()
        {
            this.Action = "changeLineItemsOrder";
        }
    }
}
