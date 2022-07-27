namespace commercetools.Sdk.Api.Models.Products
{

    public partial class FacetRange : IFacetRange
    {
        public decimal From { get; set; }

        public string FromStr { get; set; }

        public decimal To { get; set; }

        public string ToStr { get; set; }

        public long Count { get; set; }

        public long? ProductCount { get; set; }

        public decimal Total { get; set; }

        public decimal Min { get; set; }

        public decimal Max { get; set; }

        public decimal Mean { get; set; }
    }
}
