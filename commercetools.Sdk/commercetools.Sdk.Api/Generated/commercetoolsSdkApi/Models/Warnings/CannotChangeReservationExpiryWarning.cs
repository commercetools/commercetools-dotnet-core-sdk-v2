

namespace commercetools.Sdk.Api.Models.Warnings
{

    public partial class CannotChangeReservationExpiryWarning : ICannotChangeReservationExpiryWarning
    {
        public string Code { get; set; }

        public string Message { get; set; }

        public string LineItemId { get; set; }
        public CannotChangeReservationExpiryWarning()
        {
            this.Code = "CannotChangeReservationExpiry";
        }
    }
}
