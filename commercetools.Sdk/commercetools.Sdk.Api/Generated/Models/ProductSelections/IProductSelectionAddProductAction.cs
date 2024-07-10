using commercetools.Sdk.Api.Models.Products;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.ProductSelections
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.ProductSelections.ProductSelectionAddProductAction))]
    public partial interface IProductSelectionAddProductAction : IProductSelectionUpdateAction
    {
        IProductResourceIdentifier Product { get; set; }

        IProductVariantSelection VariantSelection { get; set; }

    }
}
