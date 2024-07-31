

namespace commercetools.Sdk.Api.Models.Products
{

    public partial class ProductUnpublishAction : IProductUnpublishAction
    {
        public string Action { get; set; }
        public ProductUnpublishAction()
        {
            this.Action = "unpublish";
        }
    }
}
