using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Products
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Products.FacetRange))]
    public partial interface IFacetRange
    {
        double From { get; set; }

        string FromStr { get; set; }

        double To { get; set; }

        string ToStr { get; set; }

        long Count { get; set; }

        long? ProductCount { get; set; }

        double Total { get; set; }

        double Min { get; set; }

        double Max { get; set; }

        double Mean { get; set; }
    }
}
