using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.ImportApi.Models.Orders
{
    [TypeDiscriminator(nameof(Type))]
    [DefaultTypeDiscriminator(typeof(commercetools.Sdk.ImportApi.Models.Orders.ShippingRateInput))]
    [SubTypeDiscriminator("Classification", typeof(commercetools.Sdk.ImportApi.Models.Orders.ClassificationShippingRateInput))]
    [SubTypeDiscriminator("Score", typeof(commercetools.Sdk.ImportApi.Models.Orders.ScoreShippingRateInput))]
    public partial interface IShippingRateInput
    {
        IShippingRateInputType Type { get; set; }
    }
}
