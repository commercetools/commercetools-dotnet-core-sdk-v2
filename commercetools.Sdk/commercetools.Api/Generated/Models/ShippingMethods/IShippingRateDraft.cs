using commercetools.Api.Generated.Models.Common;
using commercetools.Api.Generated.Models.ShippingMethods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Generated.Models.ShippingMethods
{
    public interface IShippingRateDraft 
    {
        IMoney Price { get; set;}
        
        IMoney FreeAbove { get; set;}
        
        List<IShippingRatePriceTier> Tiers { get; set;}
    }
}
