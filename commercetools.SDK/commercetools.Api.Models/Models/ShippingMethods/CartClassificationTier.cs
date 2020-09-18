using commercetools.Api.Models.Common;
using commercetools.Api.Models.ShippingMethods;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.ShippingMethods
{
    [DiscriminatorValue("CartClassification")]
    public class CartClassificationTier : ShippingRatePriceTier
    {
        public string Value { get; set;}
        
        public Money Price { get; set;}
        
        public bool IsMatching { get; set;}
    }
}
