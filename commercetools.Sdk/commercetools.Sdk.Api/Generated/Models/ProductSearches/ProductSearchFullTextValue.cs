using System;


namespace commercetools.Sdk.Api.Models.ProductSearches
{

    public partial class ProductSearchFullTextValue : IProductSearchFullTextValue
    {
        public string Field { get; set; }

        public decimal? Boost { get; set; }

        public IProductSearchAttributeType AttributeType { get; set; }

        public Object Value { get; set; }

        public string Language { get; set; }

        public IProductSearchMatchType MustMatch { get; set; }
    }
}
