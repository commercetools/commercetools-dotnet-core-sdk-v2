using commercetools.Api.Models.Channels;
using commercetools.Api.Models.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Stores
{
    [DiscriminatorValue("addDistributionChannel")]
    public partial class StoresAddDistributionChannelsAction : StoreUpdateAction
    {
        public ChannelResourceIdentifier DistributionChannel { get; set;}
        public StoresAddDistributionChannelsAction()
        { 
           this.Action = "addDistributionChannel";
        }
    }
}
