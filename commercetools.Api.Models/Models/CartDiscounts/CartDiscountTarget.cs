using commercetools.Api.Models.CartDiscounts;
using Newtonsoft.Json;
using JsonSubTypes;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.CartDiscounts
{
    [JsonConverter(typeof(JsonSubtypes), "type")]
    [JsonSubtypes.KnownSubType(typeof(MultiBuyCustomLineItemsTarget), "multiBuyCustomLineItems")]
    [JsonSubtypes.KnownSubType(typeof(MultiBuyLineItemsTarget), "multiBuyLineItems")]
    [JsonSubtypes.KnownSubType(typeof(CartDiscountShippingCostTarget), "shipping")]
    [JsonSubtypes.KnownSubType(typeof(CartDiscountCustomLineItemsTarget), "customLineItems")]
    [JsonSubtypes.KnownSubType(typeof(CartDiscountLineItemsTarget), "lineItems")]
    public abstract class CartDiscountTarget 
    {
        public string Type { get; set;}
    }
}
