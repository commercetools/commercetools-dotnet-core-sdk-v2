using commercetools.Api.Models.Carts;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.Carts
{
    public class CartChangeCustomLineItemQuantityAction : CartUpdateAction
    {
        public string CustomLineItemId { get; set;}
        
        public double Quantity { get; set;}
    }
}
