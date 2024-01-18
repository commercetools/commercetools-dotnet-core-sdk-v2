using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.ProductSearches
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.ProductSearches.ProductSearchFacetResultCount))]
    public partial interface IProductSearchFacetResultCount : IProductSearchFacetResultExpression
    {
        long Value { get; set; }

    }
}
