using commercetools.Sdk.Api.Models.Channels;
using commercetools.Sdk.Api.Models.Inventories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.Inventories
{

    public partial class InventoryEntrySetSupplyChannelAction : IInventoryEntrySetSupplyChannelAction
    {
        public string Action { get; set; }

        public IChannelResourceIdentifier SupplyChannel { get; set; }
        public InventoryEntrySetSupplyChannelAction()
        {
            this.Action = "setSupplyChannel";
        }
    }
}
