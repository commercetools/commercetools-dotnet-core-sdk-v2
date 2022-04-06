using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.HistoryApi.Models.Labels
{
    [TypeDiscriminator(nameof(Type))]
    [DefaultTypeDiscriminator(typeof(commercetools.Sdk.HistoryApi.Models.Labels.Label))]
    [SubTypeDiscriminator("CustomerLabel", typeof(commercetools.Sdk.HistoryApi.Models.Labels.CustomerLabel))]
    [SubTypeDiscriminator("CustomObjectLabel", typeof(commercetools.Sdk.HistoryApi.Models.Labels.CustomObjectLabel))]
    [SubTypeDiscriminator("LocalizedLabel", typeof(commercetools.Sdk.HistoryApi.Models.Labels.LocalizedLabel))]
    [SubTypeDiscriminator("OrderLabel", typeof(commercetools.Sdk.HistoryApi.Models.Labels.OrderLabel))]
    [SubTypeDiscriminator("PaymentLabel", typeof(commercetools.Sdk.HistoryApi.Models.Labels.PaymentLabel))]
    [SubTypeDiscriminator("ProductLabel", typeof(commercetools.Sdk.HistoryApi.Models.Labels.ProductLabel))]
    [SubTypeDiscriminator("ReviewLabel", typeof(commercetools.Sdk.HistoryApi.Models.Labels.ReviewLabel))]
    [SubTypeDiscriminator("StringLabel", typeof(commercetools.Sdk.HistoryApi.Models.Labels.StringLabel))]
    public partial interface ILabel
    {
        string Type { get; set; }
    }
}
