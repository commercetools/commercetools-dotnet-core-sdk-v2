namespace commercetools.Sdk.Api.Models.Products
{
    public partial class FilteredFacetResult : IFilteredFacetResult
    {
        public IFacetTypes Type { get; set; }

        public long Count { get; set; }

        public long? ProductCount { get; set; }
        public FilteredFacetResult()
        {
            this.Type = IFacetTypes.FindEnum("filter");
        }
    }
}
