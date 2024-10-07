

namespace commercetools.Sdk.Api.Models.Products
{

    public partial class ProductRevertStagedChangesAction : IProductRevertStagedChangesAction
    {
        public string Action { get; set; }
        public ProductRevertStagedChangesAction()
        {
            this.Action = "revertStagedChanges";
        }
    }
}
