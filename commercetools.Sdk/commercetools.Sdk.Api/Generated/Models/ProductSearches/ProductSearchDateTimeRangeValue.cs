using System;


namespace commercetools.Sdk.Api.Models.ProductSearches
{

    public partial class ProductSearchDateTimeRangeValue : IProductSearchDateTimeRangeValue
    {
        public string Field { get; set; }

        public decimal? Boost { get; set; }

        public IProductSearchAttributeType AttributeType { get; set; }

        public DateTime? Gte { get; set; }

        public DateTime? Gt { get; set; }

        public DateTime? Lte { get; set; }

        public DateTime? Lt { get; set; }
    }
}
