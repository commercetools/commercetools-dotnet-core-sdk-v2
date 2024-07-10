namespace commercetools.Sdk.Api.Models.Projects
{

    public partial class ProjectChangeBusinessUnitStatusOnCreationAction : IProjectChangeBusinessUnitStatusOnCreationAction
    {
        public string Action { get; set; }

        public IBusinessUnitConfigurationStatus Status { get; set; }
        public ProjectChangeBusinessUnitStatusOnCreationAction()
        {
            this.Action = "changeMyBusinessUnitStatusOnCreation";
        }
    }
}
