using commercetools.Sdk.Api.Models.Channels;
using System.Collections.Generic;


namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class StoreDistributionChannelsChangedMessagePayload : IStoreDistributionChannelsChangedMessagePayload
    {
        public string Type { get; set; }

        public List<IChannelReference> AddedDistributionChannels { get; set; }

        public List<IChannelReference> RemovedDistributionChannels { get; set; }
        public StoreDistributionChannelsChangedMessagePayload()
        {
            this.Type = "StoreDistributionChannelsChanged";
        }
    }
}
