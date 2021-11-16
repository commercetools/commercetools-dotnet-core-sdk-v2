using commercetools.Api.Models.Channels;
using System.Collections.Generic;


namespace commercetools.Api.Models.Stores
{
    public partial class StoreSetDistributionChannelsAction : IStoreSetDistributionChannelsAction
    {
        public string Action { get; set;}
        
        public List<IChannelResourceIdentifier> DistributionChannels { get; set;}
        public StoreSetDistributionChannelsAction()
        { 
           this.Action = "setDistributionChannels";
        }
    }
}
