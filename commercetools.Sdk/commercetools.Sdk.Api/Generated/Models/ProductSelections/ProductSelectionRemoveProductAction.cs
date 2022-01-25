using commercetools.Api.Models.Products;


namespace commercetools.Api.Models.ProductSelections
{
    public partial class ProductSelectionRemoveProductAction : IProductSelectionRemoveProductAction
    {
        public string Action { get; set; }

        public IProductResourceIdentifier Product { get; set; }
        public ProductSelectionRemoveProductAction()
        {
            this.Action = "removeProduct";
        }
    }
}
