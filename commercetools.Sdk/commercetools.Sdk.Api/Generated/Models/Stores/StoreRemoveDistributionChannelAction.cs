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

    public partial class StoreRemoveDistributionChannelAction : IStoreRemoveDistributionChannelAction
    {
        public string Action { get; set; }

        public IChannelResourceIdentifier DistributionChannel { get; set; }
        public StoreRemoveDistributionChannelAction()
        {
            this.Action = "removeDistributionChannel";
        }
    }
}
