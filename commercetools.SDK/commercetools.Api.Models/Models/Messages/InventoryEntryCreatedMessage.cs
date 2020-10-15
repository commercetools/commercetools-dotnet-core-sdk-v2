using commercetools.Api.Models.Inventories;
using commercetools.Api.Models.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    [DiscriminatorValue("InventoryEntryCreated")]
    public partial class InventoryEntryCreatedMessage : Message
    {
        public InventoryEntry InventoryEntry { get; set;}
        public InventoryEntryCreatedMessage()
        { 
           this.Type = "InventoryEntryCreated";
        }
    }
}
