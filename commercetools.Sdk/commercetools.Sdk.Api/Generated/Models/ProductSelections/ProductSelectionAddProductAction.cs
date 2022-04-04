using commercetools.Sdk.Api.Models.Products;


namespace commercetools.Sdk.Api.Models.ProductSelections
{
    public partial class ProductSelectionAddProductAction : IProductSelectionAddProductAction
    {
        public string Action { get; set; }

        public IProductResourceIdentifier Product { get; set; }
        public ProductSelectionAddProductAction()
        {
            this.Action = "addProduct";
        }
    }
}
