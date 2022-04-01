using commercetools.Sdk.Api.Models.ShippingMethods;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Projects
{
    [TypeDiscriminator(nameof(Type))]
    [DefaultTypeDiscriminator(typeof(commercetools.Sdk.Api.Models.Projects.ShippingRateInputType))]
    [SubTypeDiscriminator("CartClassification", typeof(commercetools.Sdk.Api.Models.Projects.CartClassificationType))]
    [SubTypeDiscriminator("CartScore", typeof(commercetools.Sdk.Api.Models.Projects.CartScoreType))]
    [SubTypeDiscriminator("CartValue", typeof(commercetools.Sdk.Api.Models.Projects.CartValueType))]
    public partial interface IShippingRateInputType
    {
        IShippingRateTierType Type { get; set; }
    }
}
