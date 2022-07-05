using System;


namespace commercetools.Sdk.Api.Models.ShoppingLists
{

    public partial class ShoppingListSetLineItemCustomFieldAction : IShoppingListSetLineItemCustomFieldAction
    {
        public string Action { get; set; }

        public string LineItemId { get; set; }

        public string Name { get; set; }

        public Object Value { get; set; }
        public ShoppingListSetLineItemCustomFieldAction()
        {
            this.Action = "setLineItemCustomField";
        }
    }
}
