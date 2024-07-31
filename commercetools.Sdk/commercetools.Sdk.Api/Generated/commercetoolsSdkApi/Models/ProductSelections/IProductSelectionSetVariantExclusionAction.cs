using commercetools.Sdk.Api.Models.Products;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.ProductSelections
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.ProductSelections.ProductSelectionSetVariantExclusionAction))]
    public partial interface IProductSelectionSetVariantExclusionAction : IProductSelectionUpdateAction
    {
        IProductResourceIdentifier Product { get; set; }

        IProductVariantExclusion VariantExclusion { get; set; }

    }
}
