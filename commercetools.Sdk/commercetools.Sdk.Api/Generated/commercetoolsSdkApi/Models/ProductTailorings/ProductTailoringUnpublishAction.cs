

namespace commercetools.Sdk.Api.Models.ProductTailorings
{

    public partial class ProductTailoringUnpublishAction : IProductTailoringUnpublishAction
    {
        public string Action { get; set; }
        public ProductTailoringUnpublishAction()
        {
            this.Action = "unpublish";
        }
    }
}
