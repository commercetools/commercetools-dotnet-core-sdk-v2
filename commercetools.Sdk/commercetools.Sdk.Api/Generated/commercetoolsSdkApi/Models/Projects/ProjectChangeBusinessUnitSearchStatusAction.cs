

namespace commercetools.Sdk.Api.Models.Projects
{

    public partial class ProjectChangeBusinessUnitSearchStatusAction : IProjectChangeBusinessUnitSearchStatusAction
    {
        public string Action { get; set; }

        public IBusinessUnitSearchStatus Status { get; set; }
        public ProjectChangeBusinessUnitSearchStatusAction()
        {
            this.Action = "changeBusinessUnitSearchStatus";
        }
    }
}
