using commercetools.Api.Models.Carts;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.Carts
{
    public class CartUpdate 
    {
        public long Version { get; set;}
        
        public List<CartUpdateAction> Actions { get; set;}
    }
}
