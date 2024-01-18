using System;


namespace commercetools.Sdk.Api.Models.ProductSearches
{

    public partial class ProductSearchTimeRangeValue : IProductSearchTimeRangeValue
    {
        public string Field { get; set; }

        public decimal? Boost { get; set; }

        public IProductSearchAttributeType AttributeType { get; set; }

        public TimeSpan? Gte { get; set; }

        public TimeSpan? Gt { get; set; }

        public TimeSpan? Lte { get; set; }

        public TimeSpan? Lt { get; set; }
    }
}
