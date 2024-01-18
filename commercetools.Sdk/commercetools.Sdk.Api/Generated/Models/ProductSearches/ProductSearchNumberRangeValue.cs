namespace commercetools.Sdk.Api.Models.ProductSearches
{

    public partial class ProductSearchNumberRangeValue : IProductSearchNumberRangeValue
    {
        public string Field { get; set; }

        public decimal? Boost { get; set; }

        public IProductSearchAttributeType AttributeType { get; set; }

        public decimal? Gte { get; set; }

        public decimal? Gt { get; set; }

        public decimal? Lte { get; set; }

        public decimal? Lt { get; set; }
    }
}
