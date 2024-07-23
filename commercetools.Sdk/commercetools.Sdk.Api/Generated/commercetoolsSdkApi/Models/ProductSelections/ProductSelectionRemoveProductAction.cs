using commercetools.Sdk.Api.Models.Products;


namespace commercetools.Sdk.Api.Models.ProductSelections
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
