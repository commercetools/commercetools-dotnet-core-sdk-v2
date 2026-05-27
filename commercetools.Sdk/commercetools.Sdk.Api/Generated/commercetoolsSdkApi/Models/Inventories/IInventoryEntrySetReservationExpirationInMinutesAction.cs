using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Inventories
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Inventories.InventoryEntrySetReservationExpirationInMinutesAction))]
    public partial interface IInventoryEntrySetReservationExpirationInMinutesAction : IInventoryEntryUpdateAction
    {
        int? ReservationExpirationInMinutes { get; set; }

    }
}
