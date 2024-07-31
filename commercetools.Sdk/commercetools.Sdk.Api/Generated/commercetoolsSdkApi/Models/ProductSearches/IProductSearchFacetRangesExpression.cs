using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.ProductSearches
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.ProductSearches.ProductSearchFacetRangesExpression))]
    public partial interface IProductSearchFacetRangesExpression : IProductSearchFacetExpression
    {
        IProductSearchFacetRangesValue Ranges { get; set; }

    }
}
