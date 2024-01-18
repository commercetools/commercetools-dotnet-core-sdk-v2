namespace commercetools.Sdk.Api.Models.ProductSearches
{

    public partial class ProductSearchFacetCountValue : IProductSearchFacetCountValue
    {
        public string Name { get; set; }

        public IProductSearchFacetEnumScope Scope { get; set; }

        public IProductSearchQuery Filter { get; set; }

        public IProductSearchFacetEnumCount Level { get; set; }
    }
}
