using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.Inventories;
using System;

namespace commercetools.Sdk.Api.Models.Reservations
{

    public partial class Reservation : IReservation
    {
        public string Id { get; set; }

        public long Version { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime LastModifiedAt { get; set; }

        public DateTime ExpiresAt { get; set; }

        public ILastModifiedBy LastModifiedBy { get; set; }

        public ICreatedBy CreatedBy { get; set; }

        public IInventoryEntryReference InventoryEntry { get; set; }

        public long Quantity { get; set; }

        public IReference Owner { get; set; }

        public string LineItemId { get; set; }

        public IReservationState State { get; set; }
    }
}
