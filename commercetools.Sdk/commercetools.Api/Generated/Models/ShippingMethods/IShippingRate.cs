using commercetools.Api.Generated.Models.Common;
using commercetools.Api.Generated.Models.ShippingMethods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Generated.Models.ShippingMethods
{
    public interface IShippingRate 
    {
        ITypedMoney Price { get; set;}
        
        ITypedMoney FreeAbove { get; set;}
        
        bool IsMatching { get; set;}
        
        List<IShippingRatePriceTier> Tiers { get; set;}
    }
}
