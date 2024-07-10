using commercetools.Sdk.Api.Models.Channels;
using commercetools.Sdk.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Inventories
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Inventories.InventoryEntryDraft))]
    public partial interface IInventoryEntryDraft
    {
        string Sku { get; set; }

        string Key { get; set; }

        IChannelResourceIdentifier SupplyChannel { get; set; }

        long QuantityOnStock { get; set; }

        long? RestockableInDays { get; set; }

        DateTime? ExpectedDelivery { get; set; }

        ICustomFieldsDraft Custom { get; set; }

    }
}
