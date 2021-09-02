using commercetools.Api.Models.ShoppingLists;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.ShoppingLists
{
    public partial class ShoppingListRemoveLineItemAction : IShoppingListRemoveLineItemAction
    {
        public string Action { get; set; }

        public string LineItemId { get; set; }

        public long? Quantity { get; set; }
        public ShoppingListRemoveLineItemAction()
        {
            this.Action = "removeLineItem";
        }
    }
}
