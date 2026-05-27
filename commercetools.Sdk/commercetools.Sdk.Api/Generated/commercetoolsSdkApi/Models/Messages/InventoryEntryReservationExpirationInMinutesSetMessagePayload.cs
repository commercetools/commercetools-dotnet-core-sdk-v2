

namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class InventoryEntryReservationExpirationInMinutesSetMessagePayload : IInventoryEntryReservationExpirationInMinutesSetMessagePayload
    {
        public string Type { get; set; }

        public int? NewReservationExpirationInMinutes { get; set; }

        public int? OldReservationExpirationInMinutes { get; set; }
        public InventoryEntryReservationExpirationInMinutesSetMessagePayload()
        {
            this.Type = "InventoryEntryReservationExpirationInMinutesSet";
        }
    }
}
