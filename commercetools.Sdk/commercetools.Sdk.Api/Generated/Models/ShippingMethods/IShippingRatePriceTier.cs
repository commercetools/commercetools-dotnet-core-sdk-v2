using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.ShippingMethods
{
    [TypeDiscriminator(nameof(Type))]
    [DefaultTypeDiscriminator(typeof(commercetools.Sdk.Api.Models.ShippingMethods.ShippingRatePriceTier))]
    [SubTypeDiscriminator("CartClassification", typeof(commercetools.Sdk.Api.Models.ShippingMethods.CartClassificationTier))]
    [SubTypeDiscriminator("CartScore", typeof(commercetools.Sdk.Api.Models.ShippingMethods.CartScoreTier))]
    [SubTypeDiscriminator("CartValue", typeof(commercetools.Sdk.Api.Models.ShippingMethods.CartValueTier))]
    public partial interface IShippingRatePriceTier
    {
        IShippingRateTierType Type { get; set; }
    }
}
