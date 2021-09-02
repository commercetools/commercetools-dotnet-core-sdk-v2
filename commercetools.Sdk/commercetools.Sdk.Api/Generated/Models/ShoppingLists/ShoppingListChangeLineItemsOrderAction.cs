using commercetools.Api.Models.ShoppingLists;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.ShoppingLists
{
    public partial class ShoppingListChangeLineItemsOrderAction : IShoppingListChangeLineItemsOrderAction
    {
        public string Action { get; set; }

        public List<string> LineItemOrder { get; set; }
        public ShoppingListChangeLineItemsOrderAction()
        {
            this.Action = "changeLineItemsOrder";
        }
    }
}
