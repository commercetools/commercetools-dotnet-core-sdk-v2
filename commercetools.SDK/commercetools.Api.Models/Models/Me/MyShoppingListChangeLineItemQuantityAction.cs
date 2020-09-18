using commercetools.Api.Models.Me;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.Me
{
    [DiscriminatorValue("changeLineItemQuantity")]
    public class MyShoppingListChangeLineItemQuantityAction : MyShoppingListUpdateAction
    {
        public string LineItemId { get; set;}
        
        public long Quantity { get; set;}
    }
}
