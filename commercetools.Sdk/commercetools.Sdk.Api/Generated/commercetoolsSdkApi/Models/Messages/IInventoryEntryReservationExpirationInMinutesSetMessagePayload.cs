using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.InventoryEntryReservationExpirationInMinutesSetMessagePayload))]
    public partial interface IInventoryEntryReservationExpirationInMinutesSetMessagePayload : IMessagePayload
    {
        int? NewReservationExpirationInMinutes { get; set; }

        int? OldReservationExpirationInMinutes { get; set; }

    }
}
