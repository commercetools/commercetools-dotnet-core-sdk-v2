using commercetools.Api.Models.Channels;
using commercetools.Api.Models.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Stores
{
    [DiscriminatorValue("setSupplyChannels")]
    public partial class StoresSetSupplyChannelsAction : StoreUpdateAction
    {
        public List<ChannelResourceIdentifier> SupplyChannels { get; set;}
        public StoresSetSupplyChannelsAction()
        { 
           this.Action = "setSupplyChannels";
        }
    }
}
