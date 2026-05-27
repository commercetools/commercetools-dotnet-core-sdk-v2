

namespace commercetools.Sdk.Api.Models.Warnings
{

    public partial class CannotUpdateReservationWarning : ICannotUpdateReservationWarning
    {
        public string Code { get; set; }

        public string Message { get; set; }

        public string LineItemId { get; set; }

        public decimal RequestedQuantity { get; set; }

        public decimal ReservedQuantity { get; set; }

        public string ProductId { get; set; }

        public string Sku { get; set; }

        public string SupplyChannel { get; set; }
        public CannotUpdateReservationWarning()
        {
            this.Code = "CannotUpdateReservation";
        }
    }
}
