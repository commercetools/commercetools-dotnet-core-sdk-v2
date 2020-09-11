using commercetools.Api.Models.Channels;
using commercetools.Api.Models.Stores;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.Stores
{
    public class StoresSetSupplyChannelsAction : StoreUpdateAction
    {
        public List<ChannelResourceIdentifier> SupplyChannels { get; set;}
    }
}
