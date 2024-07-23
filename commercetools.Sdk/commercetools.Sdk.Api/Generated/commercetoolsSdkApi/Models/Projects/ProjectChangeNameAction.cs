namespace commercetools.Sdk.Api.Models.Projects
{

    public partial class ProjectChangeNameAction : IProjectChangeNameAction
    {
        public string Action { get; set; }

        public string Name { get; set; }
        public ProjectChangeNameAction()
        {
            this.Action = "changeName";
        }
    }
}
