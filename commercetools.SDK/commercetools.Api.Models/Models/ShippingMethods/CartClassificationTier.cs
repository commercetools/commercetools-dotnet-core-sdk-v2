using commercetools.Api.Models.Common;
using commercetools.Api.Models.ShippingMethods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.ShippingMethods
{
    [DiscriminatorValue("CartClassification")]
    public partial class CartClassificationTier : ShippingRatePriceTier
    {
        public string Value { get; set;}
        
        public Money Price { get; set;}
        
        public bool IsMatching { get; set;}
        public CartClassificationTier()
        { 
           this.Type = "CartClassification";
        }
    }
}
