namespace commercetools.Sdk.Api.Models.ProductSearches
{

    public partial class ProductSearchFacetDistinctBucketSortExpression : IProductSearchFacetDistinctBucketSortExpression
    {
        public IProductSearchFacetDistinctBucketSortBy By { get; set; }

        public IProductSearchSortOrder Order { get; set; }
    }
}
