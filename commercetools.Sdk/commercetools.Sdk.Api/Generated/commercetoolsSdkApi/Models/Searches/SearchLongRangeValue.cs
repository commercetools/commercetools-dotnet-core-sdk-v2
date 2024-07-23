namespace commercetools.Sdk.Api.Models.Searches
{

    public partial class SearchLongRangeValue : ISearchLongRangeValue
    {
        public string Field { get; set; }

        public decimal? Boost { get; set; }

        public ISearchFieldType FieldType { get; set; }

        public long? Gte { get; set; }

        public long? Gt { get; set; }

        public long? Lte { get; set; }

        public long? Lt { get; set; }
    }
}
