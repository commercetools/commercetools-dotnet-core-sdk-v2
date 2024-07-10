using commercetools.Sdk.Api.Models.Channels;
using commercetools.Sdk.Api.Models.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.StoreSupplyChannelsChangedMessagePayload))]
    public partial interface IStoreSupplyChannelsChangedMessagePayload : IMessagePayload
    {
        IList<IChannelReference> AddedSupplyChannels { get; set; }
        IEnumerable<IChannelReference> AddedSupplyChannelsEnumerable { set => AddedSupplyChannels = value.ToList(); }


        IList<IChannelReference> RemovedSupplyChannels { get; set; }
        IEnumerable<IChannelReference> RemovedSupplyChannelsEnumerable { set => RemovedSupplyChannels = value.ToList(); }


    }
}
