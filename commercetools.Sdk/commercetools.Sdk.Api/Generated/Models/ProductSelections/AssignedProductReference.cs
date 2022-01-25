using commercetools.Api.Models.Products;


namespace commercetools.Api.Models.ProductSelections
{
    public partial class AssignedProductReference : IAssignedProductReference
    {
        public IProductReference Product { get; set; }
    }
}
