using commercetools.Api.Models.Common;
using commercetools.Api.Models.ShippingMethods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.ShippingMethods
{
    [DeserializeAs(typeof(commercetools.Api.Models.ShippingMethods.ShippingRate))]
    public interface IShippingRate 
    {
        ITypedMoney Price { get; set;}
        
        ITypedMoney FreeAbove { get; set;}
        
        bool? IsMatching { get; set;}
        
        List<IShippingRatePriceTier> Tiers { get; set;}
    }
}
