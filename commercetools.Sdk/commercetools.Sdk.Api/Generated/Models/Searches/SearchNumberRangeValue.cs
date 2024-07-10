namespace commercetools.Sdk.Api.Models.Searches
{

    public partial class SearchNumberRangeValue : ISearchNumberRangeValue
    {
        public string Field { get; set; }

        public decimal? Boost { get; set; }

        public ISearchFieldType FieldType { get; set; }

        public decimal? Gte { get; set; }

        public decimal? Gt { get; set; }

        public decimal? Lte { get; set; }

        public decimal? Lt { get; set; }
    }
}
