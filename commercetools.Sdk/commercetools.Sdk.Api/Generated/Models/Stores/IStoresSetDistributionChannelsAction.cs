using commercetools.Api.Models.Channels;
using commercetools.Api.Models.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Stores
{
    [DeserializeAs(typeof(commercetools.Api.Models.Stores.StoresSetDistributionChannelsAction))]
    public partial interface IStoresSetDistributionChannelsAction : IStoreUpdateAction
    {
        List<IChannelResourceIdentifier> DistributionChannels { get; set;}
    }
}
