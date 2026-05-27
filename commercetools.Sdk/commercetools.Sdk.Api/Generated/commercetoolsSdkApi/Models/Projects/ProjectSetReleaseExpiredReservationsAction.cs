

namespace commercetools.Sdk.Api.Models.Projects
{

    public partial class ProjectSetReleaseExpiredReservationsAction : IProjectSetReleaseExpiredReservationsAction
    {
        public string Action { get; set; }

        public bool ReleaseExpiredReservations { get; set; }
        public ProjectSetReleaseExpiredReservationsAction()
        {
            this.Action = "setReleaseExpiredReservations";
        }
    }
}
