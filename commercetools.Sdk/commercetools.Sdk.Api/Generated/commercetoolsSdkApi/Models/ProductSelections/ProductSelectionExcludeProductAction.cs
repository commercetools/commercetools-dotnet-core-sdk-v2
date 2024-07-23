using commercetools.Sdk.Api.Models.Products;


namespace commercetools.Sdk.Api.Models.ProductSelections
{

    public partial class ProductSelectionExcludeProductAction : IProductSelectionExcludeProductAction
    {
        public string Action { get; set; }

        public IProductResourceIdentifier Product { get; set; }

        public IProductVariantExclusion VariantExclusion { get; set; }
        public ProductSelectionExcludeProductAction()
        {
            this.Action = "excludeProduct";
        }
    }
}
