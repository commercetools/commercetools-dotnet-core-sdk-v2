

namespace commercetools.Sdk.Api.Models.Projects
{

    public partial class InventoryConfiguration : IInventoryConfiguration
    {
        public int? ReservationExpirationInMinutes { get; set; }

        public bool ReleaseExpiredReservations { get; set; }
    }
}
