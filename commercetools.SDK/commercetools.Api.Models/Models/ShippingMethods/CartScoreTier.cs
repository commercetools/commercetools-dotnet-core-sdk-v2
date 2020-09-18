using commercetools.Api.Models.Common;
using commercetools.Api.Models.ShippingMethods;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.ShippingMethods
{
    [DiscriminatorValue("CartScore")]
    public class CartScoreTier : ShippingRatePriceTier
    {
        public double Score { get; set;}
        
        public Money Price { get; set;}
        
        public PriceFunction PriceFunction { get; set;}
        
        public bool IsMatching { get; set;}
    }
}
