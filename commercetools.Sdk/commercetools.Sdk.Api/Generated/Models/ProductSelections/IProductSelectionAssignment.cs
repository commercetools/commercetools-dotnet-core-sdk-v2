using commercetools.Sdk.Api.Models.Products;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.ProductSelections
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.ProductSelections.ProductSelectionAssignment))]
    public partial interface IProductSelectionAssignment
    {
        IProductReference Product { get; set; }

        IProductSelectionReference ProductSelection { get; set; }

        IProductVariantSelection VariantSelection { get; set; }

    }
}
