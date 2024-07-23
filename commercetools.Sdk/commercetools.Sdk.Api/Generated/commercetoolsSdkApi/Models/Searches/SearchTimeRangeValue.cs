using System;


namespace commercetools.Sdk.Api.Models.Searches
{

    public partial class SearchTimeRangeValue : ISearchTimeRangeValue
    {
        public string Field { get; set; }

        public decimal? Boost { get; set; }

        public ISearchFieldType FieldType { get; set; }

        public TimeSpan? Gte { get; set; }

        public TimeSpan? Gt { get; set; }

        public TimeSpan? Lte { get; set; }

        public TimeSpan? Lt { get; set; }
    }
}
