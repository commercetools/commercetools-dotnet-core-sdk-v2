using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Projects
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Projects.ProjectSetReservationExpirationInMinutesAction))]
    public partial interface IProjectSetReservationExpirationInMinutesAction : IProjectUpdateAction
    {
        int ReservationExpirationInMinutes { get; set; }

    }
}
