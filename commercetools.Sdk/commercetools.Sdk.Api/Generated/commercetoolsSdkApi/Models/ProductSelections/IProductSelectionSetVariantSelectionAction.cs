using commercetools.Sdk.Api.Models.Products;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.ProductSelections
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.ProductSelections.ProductSelectionSetVariantSelectionAction))]
    public partial interface IProductSelectionSetVariantSelectionAction : IProductSelectionUpdateAction
    {
        IProductResourceIdentifier Product { get; set; }

        IProductVariantSelection VariantSelection { get; set; }

    }
}
