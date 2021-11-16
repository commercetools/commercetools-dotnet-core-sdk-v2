namespace commercetools.Api.Models.Projects
{
    public partial class ProjectChangeCartsConfiguration : IProjectChangeCartsConfiguration
    {
        public string Action { get; set;}
        
        public ICartsConfiguration CartsConfiguration { get; set;}
        public ProjectChangeCartsConfiguration()
        { 
           this.Action = "changeCartsConfiguration";
        }
    }
}
