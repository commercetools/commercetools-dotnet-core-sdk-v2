using commercetools.Api.Models.Channels;
using commercetools.Api.Models.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Stores
{
    [DeserializeAs(typeof(commercetools.Api.Models.Stores.StoreSetSupplyChannelsAction))]
    public partial interface IStoreSetSupplyChannelsAction : IStoreUpdateAction
    {
        List<IChannelResourceIdentifier> SupplyChannels { get; set;}
    }
}
