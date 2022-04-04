using commercetools.Sdk.Api.Models.Channels;
using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.Types;
using System;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Inventories
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Inventories.InventoryEntry))]
    public partial interface IInventoryEntry : IBaseResource
    {
        new string Id { get; set; }

        new long Version { get; set; }

        new DateTime CreatedAt { get; set; }

        new DateTime LastModifiedAt { get; set; }

        ILastModifiedBy LastModifiedBy { get; set; }

        ICreatedBy CreatedBy { get; set; }

        string Key { get; set; }

        string Sku { get; set; }

        IChannelReference SupplyChannel { get; set; }

        long QuantityOnStock { get; set; }

        long AvailableQuantity { get; set; }

        long? RestockableInDays { get; set; }

        DateTime? ExpectedDelivery { get; set; }

        ICustomFields Custom { get; set; }
    }
}
