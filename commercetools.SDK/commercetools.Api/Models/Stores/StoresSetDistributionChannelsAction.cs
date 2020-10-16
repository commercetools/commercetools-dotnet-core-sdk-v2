using commercetools.Api.Models.Channels;
using commercetools.Api.Models.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Stores
{
    [DiscriminatorValue("setDistributionChannels")]
    public partial class StoresSetDistributionChannelsAction : StoreUpdateAction
    {
        public List<ChannelResourceIdentifier> DistributionChannels { get; set;}
        public StoresSetDistributionChannelsAction()
        { 
           this.Action = "setDistributionChannels";
        }
    }
}
