using commercetools.Api.Models.Channels;
using commercetools.Api.Models.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Stores
{
    [DiscriminatorValue("removeSupplyChannel")]
    public partial class StoresRemoveSupplyChannelsAction : StoreUpdateAction
    {
        public ChannelResourceIdentifier SupplyChannel { get; set;}
        public StoresRemoveSupplyChannelsAction()
        { 
           this.Action = "removeSupplyChannel";
        }
    }
}
