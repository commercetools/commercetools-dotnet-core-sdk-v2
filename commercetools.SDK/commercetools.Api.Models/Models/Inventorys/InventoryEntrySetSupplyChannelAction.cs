using commercetools.Api.Models.Channels;
using commercetools.Api.Models.Inventorys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.Inventorys
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
