using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Products
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Products.FacetRange))]
    public partial interface IFacetRange
    {
        decimal From { get; set; }

        string FromStr { get; set; }

        decimal To { get; set; }

        string ToStr { get; set; }

        long Count { get; set; }

        long? ProductCount { get; set; }

        decimal Total { get; set; }

        decimal Min { get; set; }

        decimal Max { get; set; }

        decimal Mean { get; set; }

    }
}
