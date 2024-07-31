using System;

namespace commercetools.Sdk.Api.Models.Searches
{

    public partial class SearchDateTimeRangeValue : ISearchDateTimeRangeValue
    {
        public string Field { get; set; }

        public decimal? Boost { get; set; }

        public ISearchFieldType FieldType { get; set; }

        public DateTime? Gte { get; set; }

        public DateTime? Gt { get; set; }

        public DateTime? Lte { get; set; }

        public DateTime? Lt { get; set; }
    }
}
