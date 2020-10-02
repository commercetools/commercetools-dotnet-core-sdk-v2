using commercetools.Api.Models.Inventorys;
using commercetools.Api.Models.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    [DiscriminatorValue("InventoryEntryCreated")]
    public partial class InventoryEntryCreatedMessagePayload : MessagePayload
    {
        public InventoryEntry InventoryEntry { get; set;}
        public InventoryEntryCreatedMessagePayload()
        { 
           this.Type = "InventoryEntryCreated";
        }
    }
}
