

namespace commercetools.Sdk.Api.Models.Searches
{

    public partial class SearchQueryExpressionValue : ISearchQueryExpressionValue
    {
        public string Field { get; set; }

        public decimal? Boost { get; set; }

        public ISearchFieldType FieldType { get; set; }
    }
}
