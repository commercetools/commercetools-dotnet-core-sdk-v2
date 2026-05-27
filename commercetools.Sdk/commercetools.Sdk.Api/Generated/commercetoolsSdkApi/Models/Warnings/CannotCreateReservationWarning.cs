

namespace commercetools.Sdk.Api.Models.Warnings
{

    public partial class CannotCreateReservationWarning : ICannotCreateReservationWarning
    {
        public string Code { get; set; }

        public string Message { get; set; }

        public string ProductId { get; set; }

        public string Sku { get; set; }

        public string SupplyChannel { get; set; }

        public decimal Quantity { get; set; }
        public CannotCreateReservationWarning()
        {
            this.Code = "CannotCreateReservation";
        }
    }
}
