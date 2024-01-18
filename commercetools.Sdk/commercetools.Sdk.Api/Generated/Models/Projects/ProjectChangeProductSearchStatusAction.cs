namespace commercetools.Sdk.Api.Models.Projects
{

    public partial class ProjectChangeProductSearchStatusAction : IProjectChangeProductSearchStatusAction
    {
        public string Action { get; set; }

        public IProductSearchStatus Status { get; set; }
        public ProjectChangeProductSearchStatusAction()
        {
            this.Action = "changeProductSearchStatus";
        }
    }
}
