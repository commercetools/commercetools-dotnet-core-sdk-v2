using commercetools.Api.Models.ShoppingLists;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.ShoppingLists
{
    [DiscriminatorValue("changeLineItemQuantity")]
    public partial class ShoppingListChangeLineItemQuantityAction : ShoppingListUpdateAction
    {
        public string LineItemId { get; set;}
        
        public long Quantity { get; set;}
        public ShoppingListChangeLineItemQuantityAction()
        { 
           this.Action = "changeLineItemQuantity";
        }
    }
}
