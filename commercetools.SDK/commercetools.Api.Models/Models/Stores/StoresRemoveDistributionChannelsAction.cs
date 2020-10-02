using commercetools.Api.Models.Channels;
using commercetools.Api.Models.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.Stores
{
    [DiscriminatorValue("removeDistributionChannel")]
    public partial class StoresRemoveDistributionChannelsAction : StoreUpdateAction
    {
        public ChannelResourceIdentifier DistributionChannel { get; set;}
        public StoresRemoveDistributionChannelsAction()
        { 
           this.Action = "removeDistributionChannel";
        }
    }
}
