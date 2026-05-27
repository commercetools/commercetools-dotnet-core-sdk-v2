

namespace commercetools.Sdk.Api.Models.Carts
{

    public partial class CartSetReservationExpirationInMinutesAction : ICartSetReservationExpirationInMinutesAction
    {
        public string Action { get; set; }

        public int ReservationExpirationInMinutes { get; set; }
        public CartSetReservationExpirationInMinutesAction()
        {
            this.Action = "setReservationExpirationInMinutes";
        }
    }
}
