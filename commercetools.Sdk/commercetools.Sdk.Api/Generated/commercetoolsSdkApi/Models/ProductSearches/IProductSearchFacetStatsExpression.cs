using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.ProductSearches
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.ProductSearches.ProductSearchFacetStatsExpression))]
    public partial interface IProductSearchFacetStatsExpression : IProductSearchFacetExpression
    {
        IProductSearchFacetStatsValue Stats { get; set; }

    }
}
