using commercetools.Sdk.Api.Models.Common;


namespace commercetools.Sdk.Api.Models.Reservations
{

    public partial class ReservationReference : IReservationReference
    {
        public IReferenceTypeId TypeId { get; set; }

        public string Id { get; set; }

        public IReservation Obj { get; set; }
        public ReservationReference()
        {
            this.TypeId = IReferenceTypeId.FindEnum("reservation");
        }
    }
}
