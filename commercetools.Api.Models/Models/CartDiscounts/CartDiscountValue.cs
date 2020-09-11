using commercetools.Api.Models.CartDiscounts;
using Newtonsoft.Json;
using JsonSubTypes;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.CartDiscounts
{
    [JsonConverter(typeof(JsonSubtypes), "type")]
    [JsonSubtypes.KnownSubType(typeof(CartDiscountValueAbsolute), "absolute")]
    [JsonSubtypes.KnownSubType(typeof(CartDiscountValueGiftLineItem), "giftLineItem")]
    [JsonSubtypes.KnownSubType(typeof(CartDiscountValueRelative), "relative")]
    public abstract class CartDiscountValue 
    {
        public string Type { get; set;}
    }
}
