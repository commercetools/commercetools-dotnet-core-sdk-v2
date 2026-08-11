

namespace commercetools.Sdk.Api.Models.Projects
{

    public partial class ProjectSetProductCatalogModelAction : IProjectSetProductCatalogModelAction
    {
        public string Action { get; set; }

        public IProductCatalogModel ProductCatalogModel { get; set; }
        public ProjectSetProductCatalogModelAction()
        {
            this.Action = "setProductCatalogModel";
        }
    }
}
