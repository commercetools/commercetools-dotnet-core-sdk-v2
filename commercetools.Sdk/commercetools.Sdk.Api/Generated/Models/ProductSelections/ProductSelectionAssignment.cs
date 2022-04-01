using commercetools.Sdk.Api.Models.Products;


namespace commercetools.Sdk.Api.Models.ProductSelections
{
    public partial class ProductSelectionAssignment : IProductSelectionAssignment
    {
        public IProductReference Product { get; set; }

        public IProductSelectionReference ProductSelection { get; set; }
    }
}
