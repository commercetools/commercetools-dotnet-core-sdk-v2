using commercetools.Api.Models.ShoppingLists;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.ShoppingLists
{
    public partial class ShoppingListRemoveTextLineItemAction : IShoppingListRemoveTextLineItemAction
    {
        public string Action { get; set; }

        public string TextLineItemId { get; set; }

        public long? Quantity { get; set; }
        public ShoppingListRemoveTextLineItemAction()
        {
            this.Action = "removeTextLineItem";
        }
    }
}
