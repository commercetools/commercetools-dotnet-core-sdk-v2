using commercetools.Api.Models.Inventories;
using commercetools.Api.Models.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Api.Models.Messages.InventoryEntryCreatedMessagePayload))]
    public partial interface IInventoryEntryCreatedMessagePayload : IMessagePayload
    {
        IInventoryEntry InventoryEntry { get; set; }
    }
}
