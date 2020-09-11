using commercetools.Api.Models.Stores;
using Newtonsoft.Json;
using JsonSubTypes;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.Stores
{
    [JsonConverter(typeof(JsonSubtypes), "action")]
    [JsonSubtypes.KnownSubType(typeof(StoreSetLanguagesAction), "setLanguages")]
    [JsonSubtypes.KnownSubType(typeof(StoreSetNameAction), "setName")]
    [JsonSubtypes.KnownSubType(typeof(StoresAddDistributionChannelsAction), "addDistributionChannel")]
    [JsonSubtypes.KnownSubType(typeof(StoresAddSupplyChannelsAction), "addSupplyChannel")]
    [JsonSubtypes.KnownSubType(typeof(StoresRemoveDistributionChannelsAction), "removeDistributionChannel")]
    [JsonSubtypes.KnownSubType(typeof(StoresRemoveSupplyChannelsAction), "removeSupplyChannel")]
    [JsonSubtypes.KnownSubType(typeof(StoresSetDistributionChannelsAction), "setDistributionChannels")]
    [JsonSubtypes.KnownSubType(typeof(StoresSetSupplyChannelsAction), "setSupplyChannels")]
    public abstract class StoreUpdateAction 
    {
        public string Action { get; set;}
    }
}
