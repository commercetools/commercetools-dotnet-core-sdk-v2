using commercetools.Sdk.Api.Models.Channels;
using System.Collections.Generic;


namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class StoreSupplyChannelsChangedMessagePayload : IStoreSupplyChannelsChangedMessagePayload
    {
        public string Type { get; set; }

        public List<IChannelReference> AddedSupplyChannels { get; set; }

        public List<IChannelReference> RemovedSupplyChannels { get; set; }
        public StoreSupplyChannelsChangedMessagePayload()
        {
            this.Type = "StoreSupplyChannelsChanged";
        }
    }
}
