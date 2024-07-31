using commercetools.Sdk.Api.Models.Channels;
using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.StoreDistributionChannelsChangedMessagePayload))]
    public partial interface IStoreDistributionChannelsChangedMessagePayload : IMessagePayload
    {
        IList<IChannelReference> AddedDistributionChannels { get; set; }

        IEnumerable<IChannelReference> AddedDistributionChannelsEnumerable { set => AddedDistributionChannels = value.ToList(); }

        IList<IChannelReference> RemovedDistributionChannels { get; set; }

        IEnumerable<IChannelReference> RemovedDistributionChannelsEnumerable { set => RemovedDistributionChannels = value.ToList(); }

    }
}
