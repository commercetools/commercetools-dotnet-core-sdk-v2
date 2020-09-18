using commercetools.Api.Models.Carts;
using commercetools.Api.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.OrderEdits
{
    public class OrderExcerpt 
    {
        public TypedMoney TotalPrice { get; set;}
        
        public TaxedPrice TaxedPrice { get; set;}
        
        public int Version { get; set;}
    }
}
