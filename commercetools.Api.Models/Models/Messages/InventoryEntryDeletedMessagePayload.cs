using commercetools.Api.Models.Channels;
using commercetools.Api.Models.Messages;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.Messages
{
    public class InventoryEntryDeletedMessagePayload : MessagePayload
    {
        public string Sku { get; set;}
        
        public ChannelReference SupplyChannel { get; set;}
    }
}
