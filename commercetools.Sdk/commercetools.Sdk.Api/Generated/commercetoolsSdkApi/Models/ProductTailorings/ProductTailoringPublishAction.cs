

namespace commercetools.Sdk.Api.Models.ProductTailorings
{

    public partial class ProductTailoringPublishAction : IProductTailoringPublishAction
    {
        public string Action { get; set; }
        public ProductTailoringPublishAction()
        {
            this.Action = "publish";
        }
    }
}
