using commercetools.Api.Models.Channels;
using commercetools.Api.Models.Inventorys;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.Inventorys
{
    [DiscriminatorValue("setSupplyChannel")]
    public class InventoryEntrySetSupplyChannelAction : InventoryEntryUpdateAction
    {
        public ChannelResourceIdentifier SupplyChannel { get; set;}
    }
}
