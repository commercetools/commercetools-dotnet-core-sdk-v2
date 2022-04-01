using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Carts
{
    [TypeDiscriminator(nameof(Type))]
    [DefaultTypeDiscriminator(typeof(commercetools.Sdk.Api.Models.Carts.ShippingRateInput))]
    [SubTypeDiscriminator("Classification", typeof(commercetools.Sdk.Api.Models.Carts.ClassificationShippingRateInput))]
    [SubTypeDiscriminator("Score", typeof(commercetools.Sdk.Api.Models.Carts.ScoreShippingRateInput))]
    public partial interface IShippingRateInput
    {
        string Type { get; set; }
    }
}
