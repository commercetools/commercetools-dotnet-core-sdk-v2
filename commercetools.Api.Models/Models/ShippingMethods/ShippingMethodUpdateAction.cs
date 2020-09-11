using commercetools.Api.Models.ShippingMethods;
using Newtonsoft.Json;
using JsonSubTypes;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.ShippingMethods
{
    [JsonConverter(typeof(JsonSubtypes), "action")]
    [JsonSubtypes.KnownSubType(typeof(ShippingMethodAddShippingRateAction), "addShippingRate")]
    [JsonSubtypes.KnownSubType(typeof(ShippingMethodAddZoneAction), "addZone")]
    [JsonSubtypes.KnownSubType(typeof(ShippingMethodChangeIsDefaultAction), "changeIsDefault")]
    [JsonSubtypes.KnownSubType(typeof(ShippingMethodChangeNameAction), "changeName")]
    [JsonSubtypes.KnownSubType(typeof(ShippingMethodChangeTaxCategoryAction), "changeTaxCategory")]
    [JsonSubtypes.KnownSubType(typeof(ShippingMethodRemoveShippingRateAction), "removeShippingRate")]
    [JsonSubtypes.KnownSubType(typeof(ShippingMethodRemoveZoneAction), "removeZone")]
    [JsonSubtypes.KnownSubType(typeof(ShippingMethodSetDescriptionAction), "setDescription")]
    [JsonSubtypes.KnownSubType(typeof(ShippingMethodSetKeyAction), "setKey")]
    [JsonSubtypes.KnownSubType(typeof(ShippingMethodSetLocalizedDescriptionAction), "setLocalizedDescription")]
    [JsonSubtypes.KnownSubType(typeof(ShippingMethodSetPredicateAction), "setPredicate")]
    public abstract class ShippingMethodUpdateAction 
    {
        public string Action { get; set;}
    }
}
