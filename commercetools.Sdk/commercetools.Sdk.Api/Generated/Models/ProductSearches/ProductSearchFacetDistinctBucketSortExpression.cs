using commercetools.Sdk.Api.Models.Searches;


namespace commercetools.Sdk.Api.Models.ProductSearches
{

    public partial class ProductSearchFacetDistinctBucketSortExpression : IProductSearchFacetDistinctBucketSortExpression
    {
        public IProductSearchFacetDistinctBucketSortBy By { get; set; }

        public ISearchSortOrder Order { get; set; }
    }
}
