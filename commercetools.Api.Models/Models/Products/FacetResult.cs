using commercetools.Api.Models.Products;
using Newtonsoft.Json;
using JsonSubTypes;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.Products
{
    [JsonConverter(typeof(JsonSubtypes), "type")]
    [JsonSubtypes.KnownSubType(typeof(FilteredFacetResult), "filter")]
    [JsonSubtypes.KnownSubType(typeof(RangeFacetResult), "range")]
    [JsonSubtypes.KnownSubType(typeof(TermFacetResult), "terms")]
    public abstract class FacetResult 
    {
        public FacetTypes Type { get; set;}
    }
}
