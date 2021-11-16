namespace commercetools.Api.Models.Projects
{
    public partial class ProjectSetExternalOAuthAction : IProjectSetExternalOAuthAction
    {
        public string Action { get; set;}
        
        public IExternalOAuth ExternalOAuth { get; set;}
        public ProjectSetExternalOAuthAction()
        { 
           this.Action = "setExternalOAuth";
        }
    }
}
