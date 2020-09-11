using commercetools.Api.Models.Common;
using commercetools.Api.Models.ShippingMethods;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.ShippingMethods
{
    public class CartClassificationTier : ShippingRatePriceTier
    {
        public string Value { get; set;}
        
        public Money Price { get; set;}
        
        public bool IsMatching { get; set;}
    }
}
