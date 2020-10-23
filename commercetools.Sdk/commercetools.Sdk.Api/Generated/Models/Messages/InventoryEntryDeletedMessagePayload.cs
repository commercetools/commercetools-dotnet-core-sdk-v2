using commercetools.Api.Models.Channels;
using commercetools.Api.Models.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    public  partial class InventoryEntryDeletedMessagePayload : IInventoryEntryDeletedMessagePayload
    {
        public string Type { get; set;}
        
        public string Sku { get; set;}
        
        public IChannelReference SupplyChannel { get; set;}
        public InventoryEntryDeletedMessagePayload()
        { 
           this.Type = "InventoryEntryDeleted";
        }
    }
}
