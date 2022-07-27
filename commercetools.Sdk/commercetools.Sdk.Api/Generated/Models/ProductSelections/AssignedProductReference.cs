using commercetools.Sdk.Api.Models.Products;


namespace commercetools.Sdk.Api.Models.ProductSelections
{

    public partial class AssignedProductReference : IAssignedProductReference
    {
        public IProductReference Product { get; set; }

        public IProductVariantSelection VariantSelection { get; set; }
    }
}
