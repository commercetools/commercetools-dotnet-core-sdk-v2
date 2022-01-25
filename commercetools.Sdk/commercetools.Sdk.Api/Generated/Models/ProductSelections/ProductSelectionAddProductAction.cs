using commercetools.Api.Models.Products;


namespace commercetools.Api.Models.ProductSelections
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
