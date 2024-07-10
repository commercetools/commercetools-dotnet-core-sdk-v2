using commercetools.Sdk.Api.Models.Channels;
using commercetools.Sdk.Api.Models.Common;
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
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.StoreDistributionChannelsChangedMessage))]
    public partial interface IStoreDistributionChannelsChangedMessage : IMessage
    {
        IList<IChannelReference> AddedDistributionChannels { get; set; }
        IEnumerable<IChannelReference> AddedDistributionChannelsEnumerable { set => AddedDistributionChannels = value.ToList(); }


        IList<IChannelReference> RemovedDistributionChannels { get; set; }
        IEnumerable<IChannelReference> RemovedDistributionChannelsEnumerable { set => RemovedDistributionChannels = value.ToList(); }


    }
}
