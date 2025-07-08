using commercetools.Sdk.ImportApi.Models.Common;


namespace commercetools.Sdk.ImportApi.Models.ProductSelections
{

    public partial class ProductSelectionAssignment : IProductSelectionAssignment
    {
        public IProductKeyReference Product { get; set; }

        public IVariantSelection VariantSelection { get; set; }

        public IVariantExclusion VariantExclusion { get; set; }
    }
}
