

namespace commercetools.Sdk.Api.Models.Searches
{

    public partial class SearchExistsValue : ISearchExistsValue
    {
        public string Field { get; set; }

        public decimal? Boost { get; set; }

        public ISearchFieldType FieldType { get; set; }

        public string Language { get; set; }
    }
}
