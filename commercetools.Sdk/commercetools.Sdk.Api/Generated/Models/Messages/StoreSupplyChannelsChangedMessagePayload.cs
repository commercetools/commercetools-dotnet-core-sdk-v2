using commercetools.Sdk.Api.Models.Channels;
using commercetools.Sdk.Api.Models.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


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
