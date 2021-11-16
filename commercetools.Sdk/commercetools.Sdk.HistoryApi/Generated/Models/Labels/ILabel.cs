using commercetools.Base.CustomAttributes;


namespace commercetools.HistoryApi.Models.Labels
{
    [TypeDiscriminator(nameof(Type))]
    [DefaultTypeDiscriminator(typeof(commercetools.HistoryApi.Models.Labels.Label))]
    [SubTypeDiscriminator("CustomerLabel", typeof(commercetools.HistoryApi.Models.Labels.CustomerLabel))]
    [SubTypeDiscriminator("LocalizedLabel", typeof(commercetools.HistoryApi.Models.Labels.LocalizedLabel))]
    [SubTypeDiscriminator("OrderLabel", typeof(commercetools.HistoryApi.Models.Labels.OrderLabel))]
    [SubTypeDiscriminator("PaymentLabel", typeof(commercetools.HistoryApi.Models.Labels.PaymentLabel))]
    [SubTypeDiscriminator("ProductLabel", typeof(commercetools.HistoryApi.Models.Labels.ProductLabel))]
    [SubTypeDiscriminator("ReviewLabel", typeof(commercetools.HistoryApi.Models.Labels.ReviewLabel))]
    [SubTypeDiscriminator("StringLabel", typeof(commercetools.HistoryApi.Models.Labels.StringLabel))]
    public partial interface ILabel 
    {
        string Type { get; set;}
    }
}
