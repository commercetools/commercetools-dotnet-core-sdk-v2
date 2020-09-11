using commercetools.Api.Models.Inventorys;
using commercetools.Api.Models.Messages;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.Messages
{
    public class InventoryEntryCreatedMessagePayload : MessagePayload
    {
        public InventoryEntry InventoryEntry { get; set;}
    }
}
