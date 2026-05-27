

namespace commercetools.Sdk.Api.Models.Inventories
{

    public partial class InventoryEntrySetReservationExpirationInMinutesAction : IInventoryEntrySetReservationExpirationInMinutesAction
    {
        public string Action { get; set; }

        public int? ReservationExpirationInMinutes { get; set; }
        public InventoryEntrySetReservationExpirationInMinutesAction()
        {
            this.Action = "setReservationExpirationInMinutes";
        }
    }
}
