using commercetools.Sdk.Api.Models.Searches;


namespace commercetools.Sdk.Api.Models.ProductSearches
{

    public partial class ProductSearchFacetCountValue : IProductSearchFacetCountValue
    {
        public string Name { get; set; }

        public IProductSearchFacetScopeEnum Scope { get; set; }

        public ISearchQuery Filter { get; set; }

        public IProductSearchFacetCountLevelEnum Level { get; set; }
    }
}
