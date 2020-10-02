using commercetools.Api.Models.ShoppingLists;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.ShoppingLists
{
    [DiscriminatorValue("removeTextLineItem")]
    public partial class ShoppingListRemoveTextLineItemAction : ShoppingListUpdateAction
    {
        public string TextLineItemId { get; set;}
        
        public long Quantity { get; set;}
        public ShoppingListRemoveTextLineItemAction()
        { 
           this.Action = "removeTextLineItem";
        }
    }
}
