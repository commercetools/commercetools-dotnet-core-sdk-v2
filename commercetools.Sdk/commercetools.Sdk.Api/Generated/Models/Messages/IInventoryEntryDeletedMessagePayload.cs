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
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.InventoryEntryDeletedMessagePayload))]
    public partial interface IInventoryEntryDeletedMessagePayload : IMessagePayload
    {
        string Sku { get; set; }

        IChannelReference SupplyChannel { get; set; }

    }
}
