

namespace commercetools.Sdk.Api.Models.Projects
{

    public partial class ProjectSetReservationExpirationInMinutesAction : IProjectSetReservationExpirationInMinutesAction
    {
        public string Action { get; set; }

        public int ReservationExpirationInMinutes { get; set; }
        public ProjectSetReservationExpirationInMinutesAction()
        {
            this.Action = "setReservationExpirationInMinutes";
        }
    }
}
