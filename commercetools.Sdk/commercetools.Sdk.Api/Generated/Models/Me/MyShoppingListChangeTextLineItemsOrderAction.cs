using System.Collections.Generic;


namespace commercetools.Api.Models.Me
{
    public partial class MyShoppingListChangeTextLineItemsOrderAction : IMyShoppingListChangeTextLineItemsOrderAction
    {
        public string Action { get; set; }

        public List<string> TextLineItemOrder { get; set; }
        public MyShoppingListChangeTextLineItemsOrderAction()
        {
            this.Action = "changeTextLineItemsOrder";
        }
    }
}
