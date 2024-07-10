using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.Searches
{

    public partial class SearchDateRangeValue : ISearchDateRangeValue
    {
        public string Field { get; set; }

        public decimal? Boost { get; set; }

        public ISearchFieldType FieldType { get; set; }

        public Date? Gte { get; set; }

        public Date? Gt { get; set; }

        public Date? Lte { get; set; }

        public Date? Lt { get; set; }
    }
}
