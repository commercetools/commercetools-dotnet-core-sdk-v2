namespace commercetools.Sdk.Api.Models.ProductSearches
{

    public partial class ProductSearchLongRangeValue : IProductSearchLongRangeValue
    {
        public string Field { get; set; }

        public decimal? Boost { get; set; }

        public IProductSearchAttributeType AttributeType { get; set; }

        public long? Gte { get; set; }

        public long? Gt { get; set; }

        public long? Lte { get; set; }

        public long? Lt { get; set; }
    }
}
