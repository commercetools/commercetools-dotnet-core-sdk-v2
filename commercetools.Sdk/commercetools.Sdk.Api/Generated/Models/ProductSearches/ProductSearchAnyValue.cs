using System;


namespace commercetools.Sdk.Api.Models.ProductSearches
{

    public partial class ProductSearchAnyValue : IProductSearchAnyValue
    {
        public string Field { get; set; }

        public decimal? Boost { get; set; }

        public IProductSearchAttributeType AttributeType { get; set; }

        public Object Value { get; set; }

        public string Language { get; set; }

        public bool? CaseInsensitive { get; set; }
    }
}
