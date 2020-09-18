using commercetools.Api.Models.Common;
using commercetools.Api.Models.ShippingMethods;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.ShippingMethods
{
    public class ShippingRateDraft 
    {
        public Money Price { get; set;}
        
        public Money FreeAbove { get; set;}
        
        public List<ShippingRatePriceTier> Tiers { get; set;}
    }
}
