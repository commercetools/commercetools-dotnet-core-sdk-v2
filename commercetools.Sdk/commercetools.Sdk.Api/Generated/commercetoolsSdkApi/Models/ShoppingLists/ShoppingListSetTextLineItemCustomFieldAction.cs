using System;


namespace commercetools.Sdk.Api.Models.ShoppingLists
{

    public partial class ShoppingListSetTextLineItemCustomFieldAction : IShoppingListSetTextLineItemCustomFieldAction
    {
        public string Action { get; set; }

        public string TextLineItemId { get; set; }

        public string TextLineItemKey { get; set; }

        public string Name { get; set; }

        public Object Value { get; set; }
        public ShoppingListSetTextLineItemCustomFieldAction()
        {
            this.Action = "setTextLineItemCustomField";
        }
    }
}
