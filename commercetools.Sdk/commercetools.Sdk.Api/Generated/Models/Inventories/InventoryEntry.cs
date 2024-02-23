using commercetools.Sdk.Api.Models.Channels;
using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.Types;
using System;


namespace commercetools.Sdk.Api.Models.Inventories
{

    public partial class InventoryEntry : IInventoryEntry
    {
        public string Id { get; set; }

        public long Version { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime LastModifiedAt { get; set; }

        public ILastModifiedBy LastModifiedBy { get; set; }

        public ICreatedBy CreatedBy { get; set; }

        public string Key { get; set; }

        public string Sku { get; set; }

        public IChannelReference SupplyChannel { get; set; }

        public long QuantityOnStock { get; set; }

        public long AvailableQuantity { get; set; }

        public long? RestockableInDays { get; set; }

        public DateTime? ExpectedDelivery { get; set; }

        public ICustomFields Custom { get; set; }
    }
}
