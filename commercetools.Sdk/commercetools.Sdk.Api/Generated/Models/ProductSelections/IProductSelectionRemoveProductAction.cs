using commercetools.Sdk.Api.Models.Products;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.ProductSelections
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.ProductSelections.ProductSelectionRemoveProductAction))]
    public partial interface IProductSelectionRemoveProductAction : IProductSelectionUpdateAction
    {
        IProductResourceIdentifier Product { get; set; }

    }
}
