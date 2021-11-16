using commercetools.Api.Models.Common;
using commercetools.Api.Models.ShippingMethods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.ShippingMethods
{
    public partial class ShippingRate : IShippingRate
    {
        public ITypedMoney Price { get; set;}
        
        public ITypedMoney FreeAbove { get; set;}
        
        public bool? IsMatching { get; set;}
        
        public List<IShippingRatePriceTier> Tiers { get; set;}
    }
}
