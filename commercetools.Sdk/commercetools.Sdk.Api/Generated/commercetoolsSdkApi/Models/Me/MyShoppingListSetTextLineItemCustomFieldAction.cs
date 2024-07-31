using System;

namespace commercetools.Sdk.Api.Models.Me
{

    public partial class MyShoppingListSetTextLineItemCustomFieldAction : IMyShoppingListSetTextLineItemCustomFieldAction
    {
        public string Action { get; set; }

        public string TextLineItemId { get; set; }

        public string TextLineItemKey { get; set; }

        public string Name { get; set; }

        public Object Value { get; set; }
        public MyShoppingListSetTextLineItemCustomFieldAction()
        {
            this.Action = "setTextLineItemCustomField";
        }
    }
}
