using commercetools.Api.Models.Common;
using commercetools.Api.Models.ShippingMethods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.ShippingMethods
{
    [DeserializeAs(typeof(commercetools.Api.Models.ShippingMethods.CartValueTier))]
    public interface ICartValueTier : IShippingRatePriceTier
    {
        long MinimumCentAmount { get; set;}
        
        IMoney Price { get; set;}
        
        bool IsMatching { get; set;}
    }
}
