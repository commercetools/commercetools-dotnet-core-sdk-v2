using commercetools.Api.Models.Channels;
using commercetools.Api.Models.Inventories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.Inventories
{
    [DiscriminatorValue("setSupplyChannel")]
    public partial class InventoryEntrySetSupplyChannelAction : InventoryEntryUpdateAction
    {
        public ChannelResourceIdentifier SupplyChannel { get; set;}
        public InventoryEntrySetSupplyChannelAction()
        { 
           this.Action = "setSupplyChannel";
        }
    }
}
