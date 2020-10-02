using commercetools.Api.Models.ShoppingLists;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.ShoppingLists
{
    [DiscriminatorValue("changeTextLineItemQuantity")]
    public partial class ShoppingListChangeTextLineItemQuantityAction : ShoppingListUpdateAction
    {
        public string TextLineItemId { get; set;}
        
        public long Quantity { get; set;}
        public ShoppingListChangeTextLineItemQuantityAction()
        { 
           this.Action = "changeTextLineItemQuantity";
        }
    }
}
