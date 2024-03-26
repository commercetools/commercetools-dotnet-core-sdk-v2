using System;


namespace commercetools.Sdk.Api.Models.Searches
{

    public partial class SearchFullTextValue : ISearchFullTextValue
    {
        public string Field { get; set; }

        public decimal? Boost { get; set; }

        public ISearchFieldType FieldType { get; set; }

        public Object Value { get; set; }

        public string Language { get; set; }

        public ISearchMatchType MustMatch { get; set; }
    }
}
