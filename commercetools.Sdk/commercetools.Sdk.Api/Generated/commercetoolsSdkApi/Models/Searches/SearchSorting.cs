namespace commercetools.Sdk.Api.Models.Searches
{

    public partial class SearchSorting : ISearchSorting
    {
        public string Field { get; set; }

        public string Language { get; set; }

        public ISearchSortOrder Order { get; set; }

        public ISearchSortMode Mode { get; set; }

        public ISearchFieldType FieldType { get; set; }

        public ISearchQueryExpression Filter { get; set; }
    }
}
