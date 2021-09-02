using commercetools.Api.Models.Inventories;
using commercetools.Api.Models.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    public partial class InventoryEntryCreatedMessagePayload : IInventoryEntryCreatedMessagePayload
    {
        public string Type { get; set; }

        public IInventoryEntry InventoryEntry { get; set; }
        public InventoryEntryCreatedMessagePayload()
        {
            this.Type = "InventoryEntryCreated";
        }
    }
}
