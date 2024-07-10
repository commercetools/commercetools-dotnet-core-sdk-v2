using commercetools.Sdk.Api.Models.Products;


namespace commercetools.Sdk.Api.Models.ProductSelections
{

    public partial class ProductSelectionSetVariantExclusionAction : IProductSelectionSetVariantExclusionAction
    {
        public string Action { get; set; }

        public IProductResourceIdentifier Product { get; set; }

        public IProductVariantExclusion VariantExclusion { get; set; }
        public ProductSelectionSetVariantExclusionAction()
        {
            this.Action = "setVariantExclusion";
        }
    }
}
