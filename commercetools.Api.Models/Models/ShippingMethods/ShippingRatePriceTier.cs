using commercetools.Api.Models.ShippingMethods;
using Newtonsoft.Json;
using JsonSubTypes;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.ShippingMethods
{
    [JsonConverter(typeof(JsonSubtypes), "type")]
    [JsonSubtypes.KnownSubType(typeof(CartClassificationTier), "CartClassification")]
    [JsonSubtypes.KnownSubType(typeof(CartScoreTier), "CartScore")]
    [JsonSubtypes.KnownSubType(typeof(CartValueTier), "CartValue")]
    public abstract class ShippingRatePriceTier 
    {
        public ShippingRateTierType Type { get; set;}
    }
}
