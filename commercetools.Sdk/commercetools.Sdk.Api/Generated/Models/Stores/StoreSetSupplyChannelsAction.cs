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

    public partial class StoreSetSupplyChannelsAction : IStoreSetSupplyChannelsAction
    {
        public string Action { get; set; }

        public IList<IChannelResourceIdentifier> SupplyChannels { get; set; }
        public IEnumerable<IChannelResourceIdentifier> SupplyChannelsEnumerable { set => SupplyChannels = value.ToList(); }

        public StoreSetSupplyChannelsAction()
        {
            this.Action = "setSupplyChannels";
        }
    }
}
