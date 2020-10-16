using commercetools.Api.Models.Common;
using commercetools.Api.Models.ShippingMethods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.ShippingMethods
{
    [DiscriminatorValue("CartScore")]
    public partial class CartScoreTier : ShippingRatePriceTier
    {
        public double Score { get; set;}
        
        public Money Price { get; set;}
        
        public PriceFunction PriceFunction { get; set;}
        
        public bool IsMatching { get; set;}
        public CartScoreTier()
        { 
           this.Type = "CartScore";
        }
    }
}
