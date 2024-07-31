using commercetools.Sdk.Api.Models.Searches;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.ProductSearches
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.ProductSearches.ProductSearchFacetDistinctBucketSortExpression))]
    public partial interface IProductSearchFacetDistinctBucketSortExpression
    {
        IProductSearchFacetDistinctBucketSortBy By { get; set; }

        ISearchSortOrder Order { get; set; }

    }
}
