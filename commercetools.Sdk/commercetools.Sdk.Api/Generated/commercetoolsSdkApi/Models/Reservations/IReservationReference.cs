using commercetools.Sdk.Api.Models.Common;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Reservations
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Reservations.ReservationReference))]
    public partial interface IReservationReference : IReference
    {
        new IReferenceTypeId TypeId { get; set; }

        IReservation Obj { get; set; }

        new string Id { get; set; }

    }
}
