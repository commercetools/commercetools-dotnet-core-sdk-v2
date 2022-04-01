namespace commercetools.Sdk.Api.Models.Projects
{
    public partial class ProjectChangeOrderSearchStatusAction : IProjectChangeOrderSearchStatusAction
    {
        public string Action { get; set; }

        public IOrderSearchStatus Status { get; set; }
        public ProjectChangeOrderSearchStatusAction()
        {
            this.Action = "changeOrderSearchStatus";
        }
    }
}
