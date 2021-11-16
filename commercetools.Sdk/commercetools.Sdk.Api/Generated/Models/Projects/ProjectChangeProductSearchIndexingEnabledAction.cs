namespace commercetools.Api.Models.Projects
{
    public partial class ProjectChangeProductSearchIndexingEnabledAction : IProjectChangeProductSearchIndexingEnabledAction
    {
        public string Action { get; set;}
        
        public bool Enabled { get; set;}
        public ProjectChangeProductSearchIndexingEnabledAction()
        { 
           this.Action = "changeProductSearchIndexingEnabled";
        }
    }
}
