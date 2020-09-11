using commercetools.Api.Models.Common;
using commercetools.Api.Models.ShippingMethods;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.ShippingMethods
{
    public class ShippingRate 
    {
        public TypedMoney Price { get; set;}
        
        public TypedMoney FreeAbove { get; set;}
        
        public bool IsMatching { get; set;}
        
        public List<ShippingRatePriceTier> Tiers { get; set;}
    }
}
