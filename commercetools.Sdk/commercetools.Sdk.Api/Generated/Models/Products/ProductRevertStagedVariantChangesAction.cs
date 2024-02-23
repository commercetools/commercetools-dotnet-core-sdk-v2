namespace commercetools.Sdk.Api.Models.Products
{

    public partial class ProductRevertStagedVariantChangesAction : IProductRevertStagedVariantChangesAction
    {
        public string Action { get; set; }

        public long VariantId { get; set; }
        public ProductRevertStagedVariantChangesAction()
        {
            this.Action = "revertStagedVariantChanges";
        }
    }
}
