using commercetools.Api.Models.Carts;
using Newtonsoft.Json;
using JsonSubTypes;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.Carts
{
    [JsonConverter(typeof(JsonSubtypes), "type")]
    [JsonSubtypes.KnownSubType(typeof(ScoreShippingRateInputDraft), "Score")]
    [JsonSubtypes.KnownSubType(typeof(ClassificationShippingRateInputDraft), "Classification")]
    public abstract class ShippingRateInputDraft 
    {
        public string Type { get; set;}
    }
}
