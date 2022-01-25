using commercetools.Api.Models.Products;


namespace commercetools.Api.Models.ProductSelections
{
    public partial class ProductSelectionAssignment : IProductSelectionAssignment
    {
        public IProductReference Product { get; set; }

        public IProductSelectionReference ProductSelection { get; set; }
    }
}
