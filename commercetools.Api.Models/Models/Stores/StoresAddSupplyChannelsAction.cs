using commercetools.Api.Models.Channels;
using commercetools.Api.Models.Stores;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.Stores
{
    public class StoresAddSupplyChannelsAction : StoreUpdateAction
    {
        public ChannelResourceIdentifier SupplyChannel { get; set;}
    }
}
