using commercetools.Api.Models.Inventorys;
using commercetools.Api.Models.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    [DiscriminatorValue("InventoryEntryCreated")]
    public class InventoryEntryCreatedMessage : Message
    {
        public InventoryEntry InventoryEntry { get; set;}
    }
}
