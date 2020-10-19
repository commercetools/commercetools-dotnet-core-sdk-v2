using commercetools.Api.Models.ShoppingLists;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.ShoppingLists
{
    [DiscriminatorValue("changeTextLineItemsOrder")]
    public partial class ShoppingListChangeTextLineItemsOrderAction : ShoppingListUpdateAction
    {
        public List<string> TextLineItemOrder { get; set;}
        public ShoppingListChangeTextLineItemsOrderAction()
        { 
           this.Action = "changeTextLineItemsOrder";
        }
    }
}
