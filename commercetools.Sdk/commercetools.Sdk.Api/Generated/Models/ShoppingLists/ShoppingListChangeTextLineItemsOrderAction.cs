using commercetools.Sdk.Api.Models.ShoppingLists;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.ShoppingLists
{

    public partial class ShoppingListChangeTextLineItemsOrderAction : IShoppingListChangeTextLineItemsOrderAction
    {
        public string Action { get; set; }

        public IList<string> TextLineItemOrder { get; set; }
        public IEnumerable<string> TextLineItemOrderEnumerable { set => TextLineItemOrder = value.ToList(); }

        public ShoppingListChangeTextLineItemsOrderAction()
        {
            this.Action = "changeTextLineItemsOrder";
        }
    }
}
