using commercetools.Api.Generated.Models.Common;
using commercetools.Api.Generated.Models.ShippingMethods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Generated.Models.ShippingMethods
{
    public interface ICartScoreTier : IShippingRatePriceTier
    {
        double Score { get; set;}
        
        IMoney Price { get; set;}
        
        IPriceFunction PriceFunction { get; set;}
        
        bool IsMatching { get; set;}
    }
}
