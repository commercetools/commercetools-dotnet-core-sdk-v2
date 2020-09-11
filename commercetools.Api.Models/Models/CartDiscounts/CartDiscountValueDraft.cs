using commercetools.Api.Models.CartDiscounts;
using Newtonsoft.Json;
using JsonSubTypes;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.CartDiscounts
{
    [JsonConverter(typeof(JsonSubtypes), "type")]
    [JsonSubtypes.KnownSubType(typeof(CartDiscountValueGiftLineItemDraft), "giftLineItem")]
    [JsonSubtypes.KnownSubType(typeof(CartDiscountValueRelativeDraft), "relative")]
    [JsonSubtypes.KnownSubType(typeof(CartDiscountValueAbsoluteDraft), "absolute")]
    public abstract class CartDiscountValueDraft 
    {
        public string Type { get; set;}
    }
}
