using commercetools.Sdk.Api.Models.Channels;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class StoreDistributionChannelsChangedMessagePayload : IStoreDistributionChannelsChangedMessagePayload
    {
        public string Type { get; set; }

        public IList<IChannelReference> AddedDistributionChannels { get; set; }

        public IEnumerable<IChannelReference> AddedDistributionChannelsEnumerable { set => AddedDistributionChannels = value.ToList(); }

        public IList<IChannelReference> RemovedDistributionChannels { get; set; }

        public IEnumerable<IChannelReference> RemovedDistributionChannelsEnumerable { set => RemovedDistributionChannels = value.ToList(); }
        public StoreDistributionChannelsChangedMessagePayload()
        {
            this.Type = "StoreDistributionChannelsChanged";
        }
    }
}
