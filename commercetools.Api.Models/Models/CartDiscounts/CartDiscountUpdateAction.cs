using commercetools.Api.Models.CartDiscounts;
using Newtonsoft.Json;
using JsonSubTypes;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.CartDiscounts
{
    [JsonConverter(typeof(JsonSubtypes), "action")]
    [JsonSubtypes.KnownSubType(typeof(CartDiscountChangeCartPredicateAction), "changeCartPredicate")]
    [JsonSubtypes.KnownSubType(typeof(CartDiscountChangeIsActiveAction), "changeIsActive")]
    [JsonSubtypes.KnownSubType(typeof(CartDiscountChangeNameAction), "changeName")]
    [JsonSubtypes.KnownSubType(typeof(CartDiscountChangeRequiresDiscountCodeAction), "changeRequiresDiscountCode")]
    [JsonSubtypes.KnownSubType(typeof(CartDiscountChangeSortOrderAction), "changeSortOrder")]
    [JsonSubtypes.KnownSubType(typeof(CartDiscountChangeStackingModeAction), "changeStackingMode")]
    [JsonSubtypes.KnownSubType(typeof(CartDiscountChangeTargetAction), "changeTarget")]
    [JsonSubtypes.KnownSubType(typeof(CartDiscountChangeValueAction), "changeValue")]
    [JsonSubtypes.KnownSubType(typeof(CartDiscountSetCustomFieldAction), "setCustomField")]
    [JsonSubtypes.KnownSubType(typeof(CartDiscountSetCustomTypeAction), "setCustomType")]
    [JsonSubtypes.KnownSubType(typeof(CartDiscountSetDescriptionAction), "setDescription")]
    [JsonSubtypes.KnownSubType(typeof(CartDiscountSetKeyAction), "setKey")]
    [JsonSubtypes.KnownSubType(typeof(CartDiscountSetValidFromAction), "setValidFrom")]
    [JsonSubtypes.KnownSubType(typeof(CartDiscountSetValidFromAndUntilAction), "setValidFromAndUntil")]
    [JsonSubtypes.KnownSubType(typeof(CartDiscountSetValidUntilAction), "setValidUntil")]
    public abstract class CartDiscountUpdateAction 
    {
        public string Action { get; set;}
    }
}
