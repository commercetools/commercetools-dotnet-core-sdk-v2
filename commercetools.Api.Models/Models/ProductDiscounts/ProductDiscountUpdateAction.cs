using commercetools.Api.Models.ProductDiscounts;
using Newtonsoft.Json;
using JsonSubTypes;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.ProductDiscounts
{
    [JsonConverter(typeof(JsonSubtypes), "action")]
    [JsonSubtypes.KnownSubType(typeof(ProductDiscountChangeIsActiveAction), "changeIsActive")]
    [JsonSubtypes.KnownSubType(typeof(ProductDiscountChangeNameAction), "changeName")]
    [JsonSubtypes.KnownSubType(typeof(ProductDiscountChangePredicateAction), "changePredicate")]
    [JsonSubtypes.KnownSubType(typeof(ProductDiscountChangeSortOrderAction), "changeSortOrder")]
    [JsonSubtypes.KnownSubType(typeof(ProductDiscountChangeValueAction), "changeValue")]
    [JsonSubtypes.KnownSubType(typeof(ProductDiscountSetDescriptionAction), "setDescription")]
    [JsonSubtypes.KnownSubType(typeof(ProductDiscountSetKeyAction), "setKey")]
    [JsonSubtypes.KnownSubType(typeof(ProductDiscountSetValidFromAction), "setValidFrom")]
    [JsonSubtypes.KnownSubType(typeof(ProductDiscountSetValidFromAndUntilAction), "setValidFromAndUntil")]
    [JsonSubtypes.KnownSubType(typeof(ProductDiscountSetValidUntilAction), "setValidUntil")]
    public abstract class ProductDiscountUpdateAction 
    {
        public string Action { get; set;}
    }
}
