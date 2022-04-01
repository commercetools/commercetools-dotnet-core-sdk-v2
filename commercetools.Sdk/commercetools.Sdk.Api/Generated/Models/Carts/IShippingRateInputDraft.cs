using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Carts
{
    [TypeDiscriminator(nameof(Type))]
    [DefaultTypeDiscriminator(typeof(commercetools.Sdk.Api.Models.Carts.ShippingRateInputDraft))]
    [SubTypeDiscriminator("Classification", typeof(commercetools.Sdk.Api.Models.Carts.ClassificationShippingRateInputDraft))]
    [SubTypeDiscriminator("Score", typeof(commercetools.Sdk.Api.Models.Carts.ScoreShippingRateInputDraft))]
    public partial interface IShippingRateInputDraft
    {
        string Type { get; set; }
    }
}
