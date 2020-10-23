using commercetools.Api.Generated.Models.Inventories;
using commercetools.Api.Generated.Models.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Generated.Models.Messages
{
    public interface IInventoryEntryCreatedMessagePayload : IMessagePayload
    {
        IInventoryEntry InventoryEntry { get; set;}
    }
}
