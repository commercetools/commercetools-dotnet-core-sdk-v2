using commercetools.Api.Models.Products;
using Newtonsoft.Json;
using JsonSubTypes;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.Products
{
    [JsonConverter(typeof(JsonSubtypes), "type")]
    [JsonSubtypes.KnownSubType(typeof(WhitespaceTokenizer), "whitespace")]
    [JsonSubtypes.KnownSubType(typeof(CustomTokenizer), "custom")]
    public abstract class SuggestTokenizer 
    {
        public string Type { get; set;}
    }
}
