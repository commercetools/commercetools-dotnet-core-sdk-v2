

namespace commercetools.Sdk.Api.Models.Projects
{

    public partial class ProjectChangeCartsConfigurationAction : IProjectChangeCartsConfigurationAction
    {
        public string Action { get; set; }

        public ICartsConfiguration CartsConfiguration { get; set; }
        public ProjectChangeCartsConfigurationAction()
        {
            this.Action = "changeCartsConfiguration";
        }
    }
}
