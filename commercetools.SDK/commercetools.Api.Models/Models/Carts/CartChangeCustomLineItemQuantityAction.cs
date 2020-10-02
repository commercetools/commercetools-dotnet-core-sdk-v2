using commercetools.Api.Models.Carts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.Carts
{
    [DiscriminatorValue("changeCustomLineItemQuantity")]
    public partial class CartChangeCustomLineItemQuantityAction : CartUpdateAction
    {
        public string CustomLineItemId { get; set;}
        
        public long Quantity { get; set;}
        public CartChangeCustomLineItemQuantityAction()
        { 
           this.Action = "changeCustomLineItemQuantity";
        }
    }
}
