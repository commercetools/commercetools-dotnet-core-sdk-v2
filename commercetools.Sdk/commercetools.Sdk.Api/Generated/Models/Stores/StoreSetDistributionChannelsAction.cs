using commercetools.Sdk.Api.Models.Channels;
using commercetools.Sdk.Api.Models.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


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
