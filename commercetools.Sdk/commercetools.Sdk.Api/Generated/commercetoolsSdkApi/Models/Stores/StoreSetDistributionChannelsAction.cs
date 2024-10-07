using commercetools.Sdk.Api.Models.Channels;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Sdk.Api.Models.Stores
{

    public partial class StoreSetDistributionChannelsAction : IStoreSetDistributionChannelsAction
    {
        public string Action { get; set; }

        public IList<IChannelResourceIdentifier> DistributionChannels { get; set; }

        public IEnumerable<IChannelResourceIdentifier> DistributionChannelsEnumerable { set => DistributionChannels = value.ToList(); }
        public StoreSetDistributionChannelsAction()
        {
            this.Action = "setDistributionChannels";
        }
    }
}
