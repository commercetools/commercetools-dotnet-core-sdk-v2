using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Stores
{
    [TypeDiscriminator(nameof(Action))]
    [SubTypeDiscriminator("addDistributionChannel", typeof(commercetools.Api.Models.Stores.StoreAddDistributionChannelAction))]
    [SubTypeDiscriminator("addSupplyChannel", typeof(commercetools.Api.Models.Stores.StoreAddSupplyChannelAction))]
    [SubTypeDiscriminator("removeDistributionChannel", typeof(commercetools.Api.Models.Stores.StoreRemoveDistributionChannelAction))]
    [SubTypeDiscriminator("removeSupplyChannel", typeof(commercetools.Api.Models.Stores.StoreRemoveSupplyChannelAction))]
    [SubTypeDiscriminator("setCustomField", typeof(commercetools.Api.Models.Stores.StoreSetCustomFieldAction))]
    [SubTypeDiscriminator("setCustomType", typeof(commercetools.Api.Models.Stores.StoreSetCustomTypeAction))]
    [SubTypeDiscriminator("setDistributionChannels", typeof(commercetools.Api.Models.Stores.StoreSetDistributionChannelsAction))]
    [SubTypeDiscriminator("setLanguages", typeof(commercetools.Api.Models.Stores.StoreSetLanguagesAction))]
    [SubTypeDiscriminator("setName", typeof(commercetools.Api.Models.Stores.StoreSetNameAction))]
    [SubTypeDiscriminator("setSupplyChannels", typeof(commercetools.Api.Models.Stores.StoreSetSupplyChannelsAction))]
    public partial interface IStoreUpdateAction 
    {
        string Action { get; set;}
    }
}
