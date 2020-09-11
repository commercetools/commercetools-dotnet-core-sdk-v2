using commercetools.Api.Models.ProductDiscounts;
using Newtonsoft.Json;
using JsonSubTypes;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.ProductDiscounts
{
    [JsonConverter(typeof(JsonSubtypes), "type")]
    [JsonSubtypes.KnownSubType(typeof(ProductDiscountValueExternalDraft), "external")]
    [JsonSubtypes.KnownSubType(typeof(ProductDiscountValueRelativeDraft), "relative")]
    [JsonSubtypes.KnownSubType(typeof(ProductDiscountValueAbsoluteDraft), "absolute")]
    public abstract class ProductDiscountValueDraft 
    {
        public string Type { get; set;}
    }
}
