using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Projects
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Projects.ProjectSetReleaseExpiredReservationsAction))]
    public partial interface IProjectSetReleaseExpiredReservationsAction : IProjectUpdateAction
    {
        bool ReleaseExpiredReservations { get; set; }

    }
}
