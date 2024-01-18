namespace commercetools.Sdk.Api.Models.ProductSearches
{

    public partial class ProductSearchExistsValue : IProductSearchExistsValue
    {
        public string Field { get; set; }

        public decimal? Boost { get; set; }

        public IProductSearchAttributeType AttributeType { get; set; }

        public string Language { get; set; }
    }
}
