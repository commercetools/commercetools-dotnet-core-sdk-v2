using commercetools.Sdk.Api.Models.Channels;
using System.Collections.Generic;
using System.Linq;


namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class StoreSupplyChannelsChangedMessagePayload : IStoreSupplyChannelsChangedMessagePayload
    {
        public string Type { get; set; }

        public IList<IChannelReference> AddedSupplyChannels { get; set; }
        public IEnumerable<IChannelReference> AddedSupplyChannelsEnumerable { set => AddedSupplyChannels = value.ToList(); }


        public IList<IChannelReference> RemovedSupplyChannels { get; set; }
        public IEnumerable<IChannelReference> RemovedSupplyChannelsEnumerable { set => RemovedSupplyChannels = value.ToList(); }

        public StoreSupplyChannelsChangedMessagePayload()
        {
            this.Type = "StoreSupplyChannelsChanged";
        }
    }
}
