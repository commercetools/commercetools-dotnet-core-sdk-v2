using commercetools.Api.Models.Carts;
using Newtonsoft.Json;
using JsonSubTypes;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.Carts
{
    [JsonConverter(typeof(JsonSubtypes), "type")]
    [JsonSubtypes.KnownSubType(typeof(ClassificationShippingRateInput), "Classification")]
    [JsonSubtypes.KnownSubType(typeof(ScoreShippingRateInput), "Score")]
    public abstract class ShippingRateInput 
    {
        public string Type { get; set;}
    }
}
