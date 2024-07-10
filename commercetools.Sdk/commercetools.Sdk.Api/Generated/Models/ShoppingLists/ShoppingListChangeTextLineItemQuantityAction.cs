using commercetools.Sdk.Api.Models.ShoppingLists;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.ShoppingLists
{

    public partial class ShoppingListChangeTextLineItemQuantityAction : IShoppingListChangeTextLineItemQuantityAction
    {
        public string Action { get; set; }

        public string TextLineItemId { get; set; }

        public string TextLineItemKey { get; set; }

        public long Quantity { get; set; }
        public ShoppingListChangeTextLineItemQuantityAction()
        {
            this.Action = "changeTextLineItemQuantity";
        }
    }
}
