using commercetools.Sdk.Api.Models.Channels;
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
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.InventoryEntryQuantitySetMessagePayload))]
    public partial interface IInventoryEntryQuantitySetMessagePayload : IMessagePayload
    {
        long OldQuantityOnStock { get; set; }

        long NewQuantityOnStock { get; set; }

        long OldAvailableQuantity { get; set; }

        long NewAvailableQuantity { get; set; }

        IChannelReference SupplyChannel { get; set; }

    }
}
