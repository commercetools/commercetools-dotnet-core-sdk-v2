using commercetools.Api.Models.Projects;
using commercetools.Api.Models.ShippingMethods;
using Newtonsoft.Json;
using JsonSubTypes;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.Projects
{
    [JsonConverter(typeof(JsonSubtypes), "type")]
    [JsonSubtypes.KnownSubType(typeof(CartClassificationType), "CartClassification")]
    [JsonSubtypes.KnownSubType(typeof(CartScoreType), "CartScore")]
    [JsonSubtypes.KnownSubType(typeof(CartValueType), "CartValue")]
    public abstract class ShippingRateInputType 
    {
        public ShippingRateTierType Type { get; set;}
    }
}
