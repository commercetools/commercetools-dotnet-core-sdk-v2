using commercetools.Api.Models.Common;
using commercetools.Api.Models.ShippingMethods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.ShippingMethods
{
    public partial class ShippingRate 
    {
        public TypedMoney Price { get; set;}
        
        public TypedMoney FreeAbove { get; set;}
        
        public bool IsMatching { get; set;}
        
        public List<ShippingRatePriceTier> Tiers { get; set;}
    }
}
