using commercetools.Sdk.Api.Models.Products;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.ProductSelections
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.ProductSelections.ProductSelectionExcludeProductAction))]
    public partial interface IProductSelectionExcludeProductAction : IProductSelectionUpdateAction
    {
        IProductResourceIdentifier Product { get; set; }

        IProductVariantExclusion VariantExclusion { get; set; }

    }
}
