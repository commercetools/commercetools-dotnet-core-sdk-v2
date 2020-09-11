using commercetools.Api.Models.DiscountCodes;
using Newtonsoft.Json;
using JsonSubTypes;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.DiscountCodes
{
    [JsonConverter(typeof(JsonSubtypes), "action")]
    [JsonSubtypes.KnownSubType(typeof(DiscountCodeChangeCartDiscountsAction), "changeCartDiscounts")]
    [JsonSubtypes.KnownSubType(typeof(DiscountCodeChangeGroupsAction), "changeGroups")]
    [JsonSubtypes.KnownSubType(typeof(DiscountCodeChangeIsActiveAction), "changeIsActive")]
    [JsonSubtypes.KnownSubType(typeof(DiscountCodeSetCartPredicateAction), "setCartPredicate")]
    [JsonSubtypes.KnownSubType(typeof(DiscountCodeSetCustomFieldAction), "setCustomField")]
    [JsonSubtypes.KnownSubType(typeof(DiscountCodeSetCustomTypeAction), "setCustomType")]
    [JsonSubtypes.KnownSubType(typeof(DiscountCodeSetDescriptionAction), "setDescription")]
    [JsonSubtypes.KnownSubType(typeof(DiscountCodeSetMaxApplicationsAction), "setMaxApplications")]
    [JsonSubtypes.KnownSubType(typeof(DiscountCodeSetMaxApplicationsPerCustomerAction), "setMaxApplicationsPerCustomer")]
    [JsonSubtypes.KnownSubType(typeof(DiscountCodeSetNameAction), "setName")]
    [JsonSubtypes.KnownSubType(typeof(DiscountCodeSetValidFromAction), "setValidFrom")]
    [JsonSubtypes.KnownSubType(typeof(DiscountCodeSetValidFromAndUntilAction), "setValidFromAndUntil")]
    [JsonSubtypes.KnownSubType(typeof(DiscountCodeSetValidUntilAction), "setValidUntil")]
    public abstract class DiscountCodeUpdateAction 
    {
        public string Action { get; set;}
    }
}
