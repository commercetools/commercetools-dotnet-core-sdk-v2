using commercetools.Api.Models.Channels;
using commercetools.Api.Models.Stores;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.Stores
{
    public class StoresRemoveDistributionChannelsAction : StoreUpdateAction
    {
        public ChannelResourceIdentifier DistributionChannel { get; set;}
    }
}
