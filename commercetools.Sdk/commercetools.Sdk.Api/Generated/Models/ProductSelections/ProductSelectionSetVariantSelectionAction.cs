using commercetools.Sdk.Api.Models.Products;


namespace commercetools.Sdk.Api.Models.ProductSelections
{

    public partial class ProductSelectionSetVariantSelectionAction : IProductSelectionSetVariantSelectionAction
    {
        public string Action { get; set; }

        public IProductResourceIdentifier Product { get; set; }

        public IProductVariantSelection VariantSelection { get; set; }
        public ProductSelectionSetVariantSelectionAction()
        {
            this.Action = "setVariantSelection";
        }
    }
}
