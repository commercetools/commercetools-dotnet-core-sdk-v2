namespace commercetools.Sdk.Api.Models.Projects
{

    public partial class ProjectChangeCustomerSearchStatusAction : IProjectChangeCustomerSearchStatusAction
    {
        public string Action { get; set; }

        public ICustomerSearchStatus Status { get; set; }
        public ProjectChangeCustomerSearchStatusAction()
        {
            this.Action = "changeCustomerSearchStatus";
        }
    }
}
