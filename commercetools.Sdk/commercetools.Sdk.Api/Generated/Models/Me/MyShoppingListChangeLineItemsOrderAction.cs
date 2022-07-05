using System.Collections.Generic;


namespace commercetools.Sdk.Api.Models.Me
{

    public partial class MyShoppingListChangeLineItemsOrderAction : IMyShoppingListChangeLineItemsOrderAction
    {
        public string Action { get; set; }

        public List<string> LineItemOrder { get; set; }
        public MyShoppingListChangeLineItemsOrderAction()
        {
            this.Action = "changeLineItemsOrder";
        }
    }
}
