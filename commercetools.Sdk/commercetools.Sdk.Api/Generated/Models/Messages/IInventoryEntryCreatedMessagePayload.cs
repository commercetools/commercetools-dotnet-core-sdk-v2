using commercetools.Sdk.Api.Models.Inventories;
using commercetools.Sdk.Api.Models.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.InventoryEntryCreatedMessagePayload))]
    public partial interface IInventoryEntryCreatedMessagePayload : IMessagePayload
    {
        IInventoryEntry InventoryEntry { get; set; }

    }
}
