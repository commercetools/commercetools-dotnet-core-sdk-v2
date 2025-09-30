

namespace commercetools.Sdk.Api.Models.Projects
{

    public partial class ProjectSetDiscountsConfigurationAction : IProjectSetDiscountsConfigurationAction
    {
        public string Action { get; set; }

        public IDiscountsConfiguration DiscountsConfiguration { get; set; }
        public ProjectSetDiscountsConfigurationAction()
        {
            this.Action = "setDiscountsConfiguration";
        }
    }
}
