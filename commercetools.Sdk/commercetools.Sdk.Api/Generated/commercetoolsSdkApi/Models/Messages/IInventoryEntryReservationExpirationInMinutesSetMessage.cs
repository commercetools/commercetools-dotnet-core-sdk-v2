using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.InventoryEntryReservationExpirationInMinutesSetMessage))]
    public partial interface IInventoryEntryReservationExpirationInMinutesSetMessage : IMessage
    {
        int? NewReservationExpirationInMinutes { get; set; }

        int? OldReservationExpirationInMinutes { get; set; }

    }
}
