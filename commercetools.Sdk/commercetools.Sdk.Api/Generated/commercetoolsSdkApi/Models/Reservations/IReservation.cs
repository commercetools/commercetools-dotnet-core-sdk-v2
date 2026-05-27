using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.Inventories;
using System;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Reservations
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Reservations.Reservation))]
    public partial interface IReservation : IBaseResource
    {
        new string Id { get; set; }

        new long Version { get; set; }

        new DateTime CreatedAt { get; set; }

        new DateTime LastModifiedAt { get; set; }

        DateTime ExpiresAt { get; set; }

        ILastModifiedBy LastModifiedBy { get; set; }

        ICreatedBy CreatedBy { get; set; }

        IInventoryEntryReference InventoryEntry { get; set; }

        long Quantity { get; set; }

        IReference Owner { get; set; }

        string LineItemId { get; set; }

        IReservationState State { get; set; }

    }
}
