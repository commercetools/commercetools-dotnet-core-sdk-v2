using System;


namespace commercetools.Sdk.Api.Models.Me
{

    public partial class MyShoppingListSetLineItemCustomFieldAction : IMyShoppingListSetLineItemCustomFieldAction
    {
        public string Action { get; set; }

        public string LineItemId { get; set; }

        public string Name { get; set; }

        public Object Value { get; set; }
        public MyShoppingListSetLineItemCustomFieldAction()
        {
            this.Action = "setLineItemCustomField";
        }
    }
}
