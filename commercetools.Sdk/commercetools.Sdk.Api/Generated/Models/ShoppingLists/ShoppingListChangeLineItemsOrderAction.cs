using commercetools.Api.Models.ShoppingLists;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.ShoppingLists
{
    [DiscriminatorValue("changeLineItemsOrder")]
    public partial class ShoppingListChangeLineItemsOrderAction : ShoppingListUpdateAction
    {
        public List<string> LineItemOrder { get; set;}
        public ShoppingListChangeLineItemsOrderAction()
        { 
           this.Action = "changeLineItemsOrder";
        }
    }
}
