using commercetools.Sdk.Api.Models.Searches;


namespace commercetools.Sdk.Api.Models.ProductSearches
{

    public partial class ProductSearchFacetStatsValue : IProductSearchFacetStatsValue
    {
        public string Name { get; set; }

        public IProductSearchFacetScopeEnum Scope { get; set; }

        public ISearchQuery Filter { get; set; }

        public string Field { get; set; }

        public ISearchFieldType FieldType { get; set; }
    }
}
