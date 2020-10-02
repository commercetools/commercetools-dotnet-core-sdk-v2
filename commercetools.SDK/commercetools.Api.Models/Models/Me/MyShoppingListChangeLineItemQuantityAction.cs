using commercetools.Api.Models.Me;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.Me
{
    [DiscriminatorValue("changeLineItemQuantity")]
    public partial class MyShoppingListChangeLineItemQuantityAction : MyShoppingListUpdateAction
    {
        public string LineItemId { get; set;}
        
        public long Quantity { get; set;}
        public MyShoppingListChangeLineItemQuantityAction()
        { 
           this.Action = "changeLineItemQuantity";
        }
    }
}
