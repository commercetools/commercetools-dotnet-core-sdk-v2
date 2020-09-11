using commercetools.Api.Models.Common;
using Newtonsoft.Json;
using JsonSubTypes;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.Common
{
    [JsonConverter(typeof(JsonSubtypes), "type")]
    [JsonSubtypes.KnownSubType(typeof(GeoJsonPoint), "Point")]
    public abstract class GeoJson 
    {
        public string Type { get; set;}
    }
}
