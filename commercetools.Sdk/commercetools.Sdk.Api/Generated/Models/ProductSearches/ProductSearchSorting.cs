namespace commercetools.Sdk.Api.Models.ProductSearches
{

    public partial class ProductSearchSorting : IProductSearchSorting
    {
        public string Field { get; set; }

        public string Language { get; set; }

        public IProductSearchSortOrder Order { get; set; }

        public IProductSearchSortMode Mode { get; set; }

        public IProductSearchAttributeType AttributeType { get; set; }

        public IProductSearchQueryExpression Filter { get; set; }
    }
}
