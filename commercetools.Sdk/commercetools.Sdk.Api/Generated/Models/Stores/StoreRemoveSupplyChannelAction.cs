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

    public partial class StoreRemoveSupplyChannelAction : IStoreRemoveSupplyChannelAction
    {
        public string Action { get; set; }

        public IChannelResourceIdentifier SupplyChannel { get; set; }
        public StoreRemoveSupplyChannelAction()
        {
            this.Action = "removeSupplyChannel";
        }
    }
}
