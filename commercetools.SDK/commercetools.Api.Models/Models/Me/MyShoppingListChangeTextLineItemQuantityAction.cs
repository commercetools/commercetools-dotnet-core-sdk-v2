using commercetools.Api.Models.Me;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.Me
{
    [DiscriminatorValue("changeTextLineItemQuantity")]
    public class MyShoppingListChangeTextLineItemQuantityAction : MyShoppingListUpdateAction
    {
        public string TextLineItemId { get; set;}
        
        public long Quantity { get; set;}
    }
}
