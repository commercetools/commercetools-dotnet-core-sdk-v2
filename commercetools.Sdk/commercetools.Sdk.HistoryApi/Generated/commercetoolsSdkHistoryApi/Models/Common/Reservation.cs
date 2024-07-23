namespace commercetools.Sdk.HistoryApi.Models.Common
{

    public partial class Reservation : IReservation
    {
        public int Quantity { get; set; }

        public IReference Owner { get; set; }

        public string CreatedAt { get; set; }

        public string CheckoutStartedAt { get; set; }
    }
}
