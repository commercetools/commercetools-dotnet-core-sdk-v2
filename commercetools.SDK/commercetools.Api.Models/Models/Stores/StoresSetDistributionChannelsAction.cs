using commercetools.Api.Models.Channels;
using commercetools.Api.Models.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.Stores
{
    [DiscriminatorValue("setDistributionChannels")]
    public class StoresSetDistributionChannelsAction : StoreUpdateAction
    {
        public List<ChannelResourceIdentifier> DistributionChannels { get; set;}
    }
}
