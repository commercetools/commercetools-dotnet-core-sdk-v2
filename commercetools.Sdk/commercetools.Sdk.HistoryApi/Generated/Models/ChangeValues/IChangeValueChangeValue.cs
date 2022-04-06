using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.HistoryApi.Models.ChangeValues
{
    [TypeDiscriminator(nameof(Type))]
    [DefaultTypeDiscriminator(typeof(commercetools.Sdk.HistoryApi.Models.ChangeValues.ChangeValueChangeValue))]
    [SubTypeDiscriminator("absolute", typeof(commercetools.Sdk.HistoryApi.Models.ChangeValues.ChangeValueAbsoluteChangeValue))]
    [SubTypeDiscriminator("external", typeof(commercetools.Sdk.HistoryApi.Models.ChangeValues.ChangeValueExternalChangeValue))]
    [SubTypeDiscriminator("giftLineItem", typeof(commercetools.Sdk.HistoryApi.Models.ChangeValues.ChangeValueGiftLineItemChangeValue))]
    [SubTypeDiscriminator("relative", typeof(commercetools.Sdk.HistoryApi.Models.ChangeValues.ChangeValueRelativeChangeValue))]
    public partial interface IChangeValueChangeValue
    {
        string Type { get; set; }
    }
}
