using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.ProductSearches
{

    public partial class ProductSearchDateRangeValue : IProductSearchDateRangeValue
    {
        public string Field { get; set; }

        public decimal? Boost { get; set; }

        public IProductSearchAttributeType AttributeType { get; set; }

        public Date? Gte { get; set; }

        public Date? Gt { get; set; }

        public Date? Lte { get; set; }

        public Date? Lt { get; set; }
    }
}
