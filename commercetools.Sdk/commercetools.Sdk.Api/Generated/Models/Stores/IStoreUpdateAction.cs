using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Stores
{
    [TypeDiscriminator(nameof(Action))]
    [SubTypeDiscriminator("setLanguages", typeof(commercetools.Api.Models.Stores.StoreSetLanguagesAction))]
    [SubTypeDiscriminator("setName", typeof(commercetools.Api.Models.Stores.StoreSetNameAction))]
    [SubTypeDiscriminator("addDistributionChannel", typeof(commercetools.Api.Models.Stores.StoresAddDistributionChannelsAction))]
    [SubTypeDiscriminator("addSupplyChannel", typeof(commercetools.Api.Models.Stores.StoresAddSupplyChannelsAction))]
    [SubTypeDiscriminator("removeDistributionChannel", typeof(commercetools.Api.Models.Stores.StoresRemoveDistributionChannelsAction))]
    [SubTypeDiscriminator("removeSupplyChannel", typeof(commercetools.Api.Models.Stores.StoresRemoveSupplyChannelsAction))]
    [SubTypeDiscriminator("setDistributionChannels", typeof(commercetools.Api.Models.Stores.StoresSetDistributionChannelsAction))]
    [SubTypeDiscriminator("setSupplyChannels", typeof(commercetools.Api.Models.Stores.StoresSetSupplyChannelsAction))]
    public interface IStoreUpdateAction 
    {
        string Action { get; set;}
    }
}
