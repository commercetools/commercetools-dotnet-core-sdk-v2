using commercetools.Api.Models.Channels;
using commercetools.Api.Models.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.Stores
{
    [DiscriminatorValue("removeSupplyChannel")]
    public class StoresRemoveSupplyChannelsAction : StoreUpdateAction
    {
        public ChannelResourceIdentifier SupplyChannel { get; set;}
    }
}
