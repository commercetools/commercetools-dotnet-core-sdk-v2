using commercetools.Api.Models.Inventorys;
using Newtonsoft.Json;
using JsonSubTypes;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.Inventorys
{
    [JsonConverter(typeof(JsonSubtypes), "action")]
    [JsonSubtypes.KnownSubType(typeof(InventoryEntryAddQuantityAction), "addQuantity")]
    [JsonSubtypes.KnownSubType(typeof(InventoryEntryChangeQuantityAction), "changeQuantity")]
    [JsonSubtypes.KnownSubType(typeof(InventoryEntryRemoveQuantityAction), "removeQuantity")]
    [JsonSubtypes.KnownSubType(typeof(InventoryEntrySetCustomFieldAction), "setCustomField")]
    [JsonSubtypes.KnownSubType(typeof(InventoryEntrySetCustomTypeAction), "setCustomType")]
    [JsonSubtypes.KnownSubType(typeof(InventoryEntrySetExpectedDeliveryAction), "setExpectedDelivery")]
    [JsonSubtypes.KnownSubType(typeof(InventoryEntrySetRestockableInDaysAction), "setRestockableInDays")]
    [JsonSubtypes.KnownSubType(typeof(InventoryEntrySetSupplyChannelAction), "setSupplyChannel")]
    public abstract class InventoryEntryUpdateAction 
    {
        public string Action { get; set;}
    }
}
