using commercetools.Api.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.Carts
{
    public class TaxedItemPrice 
    {
        public TypedMoney TotalNet { get; set;}
        
        public TypedMoney TotalGross { get; set;}
    }
}
