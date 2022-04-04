using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Products
{
    [TypeDiscriminator(nameof(Type))]
    [DefaultTypeDiscriminator(typeof(commercetools.Sdk.Api.Models.Products.FacetResult))]
    [SubTypeDiscriminator("filter", typeof(commercetools.Sdk.Api.Models.Products.FilteredFacetResult))]
    [SubTypeDiscriminator("range", typeof(commercetools.Sdk.Api.Models.Products.RangeFacetResult))]
    [SubTypeDiscriminator("terms", typeof(commercetools.Sdk.Api.Models.Products.TermFacetResult))]
    public partial interface IFacetResult
    {
        IFacetTypes Type { get; set; }
    }
}
