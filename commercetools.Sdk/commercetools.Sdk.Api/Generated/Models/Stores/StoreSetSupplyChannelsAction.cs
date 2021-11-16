using commercetools.Api.Models.Channels;
using System.Collections.Generic;


namespace commercetools.Api.Models.Stores
{
    public partial class StoreSetSupplyChannelsAction : IStoreSetSupplyChannelsAction
    {
        public string Action { get; set; }

        public List<IChannelResourceIdentifier> SupplyChannels { get; set; }
        public StoreSetSupplyChannelsAction()
        {
            this.Action = "setSupplyChannels";
        }
    }
}
