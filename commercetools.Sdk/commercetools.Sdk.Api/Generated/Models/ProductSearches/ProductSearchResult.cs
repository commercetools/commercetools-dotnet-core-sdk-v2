using commercetools.Sdk.Api.Models.Products;


namespace commercetools.Sdk.Api.Models.ProductSearches
{

    public partial class ProductSearchResult : IProductSearchResult
    {
        public string Id { get; set; }

        public IProductProjection ProductProjection { get; set; }

        public IProductSearchMatchingVariants MatchingVariants { get; set; }
    }
}
