using commercetools.Api.Models.Channels;
using commercetools.Api.Models.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.Stores
{
    [DiscriminatorValue("setSupplyChannels")]
    public class StoresSetSupplyChannelsAction : StoreUpdateAction
    {
        public List<ChannelResourceIdentifier> SupplyChannels { get; set;}
    }
}
