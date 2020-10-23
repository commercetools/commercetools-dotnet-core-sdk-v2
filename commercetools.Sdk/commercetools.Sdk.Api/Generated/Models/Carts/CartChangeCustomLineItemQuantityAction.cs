using commercetools.Api.Models.Carts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Carts
{
    public  partial class CartChangeCustomLineItemQuantityAction : ICartChangeCustomLineItemQuantityAction
    {
        public string Action { get; set;}
        
        public string CustomLineItemId { get; set;}
        
        public long Quantity { get; set;}
        public CartChangeCustomLineItemQuantityAction()
        { 
           this.Action = "changeCustomLineItemQuantity";
        }
    }
}
