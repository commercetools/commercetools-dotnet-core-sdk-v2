using commercetools.Api.Models.Channels;
using commercetools.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.Inventorys
{
    public class InventoryEntryDraft 
    {
        public string Sku { get; set;}
        
        public ChannelResourceIdentifier SupplyChannel { get; set;}
        
        public long QuantityOnStock { get; set;}
        
        public long RestockableInDays { get; set;}
        
        public DateTime ExpectedDelivery { get; set;}
        
        public CustomFieldsDraft Custom { get; set;}
    }
}
