using commercetools.Sdk.Api.Models.ShoppingLists;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.ShoppingLists
{

    public partial class ShoppingListChangeLineItemsOrderAction : IShoppingListChangeLineItemsOrderAction
    {
        public string Action { get; set; }

        public IList<string> LineItemOrder { get; set; }
        public IEnumerable<string> LineItemOrderEnumerable { set => LineItemOrder = value.ToList(); }

        public ShoppingListChangeLineItemsOrderAction()
        {
            this.Action = "changeLineItemsOrder";
        }
    }
}
