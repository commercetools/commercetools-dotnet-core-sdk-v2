using commercetools.Api.Models.Carts;
using commercetools.Api.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.Carts
{
    public class TaxedPrice 
    {
        public TypedMoney TotalNet { get; set;}
        
        public TypedMoney TotalGross { get; set;}
        
        public List<TaxPortion> TaxPortions { get; set;}
    }
}
