using System.Collections.Generic;
using System.Linq;


namespace commercetools.Sdk.Api.Models.Me
{

    public partial class MyShoppingListChangeLineItemsOrderAction : IMyShoppingListChangeLineItemsOrderAction
    {
        public string Action { get; set; }

        public IList<string> LineItemOrder { get; set; }
        public IEnumerable<string> LineItemOrderEnumerable { set => LineItemOrder = value.ToList(); }

        public MyShoppingListChangeLineItemsOrderAction()
        {
            this.Action = "changeLineItemsOrder";
        }
    }
}
