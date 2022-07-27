using System;


namespace commercetools.Sdk.Api.Models.ShoppingLists
{

    public partial class ShoppingListSetCustomFieldAction : IShoppingListSetCustomFieldAction
    {
        public string Action { get; set; }

        public string Name { get; set; }

        public Object Value { get; set; }
        public ShoppingListSetCustomFieldAction()
        {
            this.Action = "setCustomField";
        }
    }
}
