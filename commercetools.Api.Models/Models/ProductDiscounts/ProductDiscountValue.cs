using commercetools.Api.Models.ProductDiscounts;
using Newtonsoft.Json;
using JsonSubTypes;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.ProductDiscounts
{
    [JsonConverter(typeof(JsonSubtypes), "type")]
    [JsonSubtypes.KnownSubType(typeof(ProductDiscountValueAbsolute), "absolute")]
    [JsonSubtypes.KnownSubType(typeof(ProductDiscountValueExternal), "external")]
    [JsonSubtypes.KnownSubType(typeof(ProductDiscountValueRelative), "relative")]
    public abstract class ProductDiscountValue 
    {
        public string Type { get; set;}
    }
}
