using commercetools.Api.Models.Channels;
using commercetools.Api.Models.Inventorys;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.Inventorys
{
    public class InventoryEntrySetSupplyChannelAction : InventoryEntryUpdateAction
    {
        public ChannelResourceIdentifier SupplyChannel { get; set;}
    }
}
