using System.Collections.Generic;
using System.Linq;


namespace commercetools.Sdk.Api.Models.Me
{

    public partial class MyShoppingListChangeTextLineItemsOrderAction : IMyShoppingListChangeTextLineItemsOrderAction
    {
        public string Action { get; set; }

        public IList<string> TextLineItemOrder { get; set; }
        public IEnumerable<string> TextLineItemOrderEnumerable { set => TextLineItemOrder = value.ToList(); }

        public MyShoppingListChangeTextLineItemsOrderAction()
        {
            this.Action = "changeTextLineItemsOrder";
        }
    }
}
