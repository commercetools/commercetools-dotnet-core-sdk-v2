using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.HistoryApi.Models.ChangeValues
{
    [TypeDiscriminator(nameof(Type))]
    [DefaultTypeDiscriminator(typeof(commercetools.Sdk.HistoryApi.Models.ChangeValues.ChangeTargetChangeValue))]
    [SubTypeDiscriminator("customLineItems", typeof(commercetools.Sdk.HistoryApi.Models.ChangeValues.ChangeTargetCustomLineItemsChangeValue))]
    [SubTypeDiscriminator("lineItems", typeof(commercetools.Sdk.HistoryApi.Models.ChangeValues.ChangeTargetLineItemsChangeValue))]
    [SubTypeDiscriminator("multiBuyCustomLineItems", typeof(commercetools.Sdk.HistoryApi.Models.ChangeValues.ChangeTargetMultiBuyCustomLineItemsChangeValue))]
    [SubTypeDiscriminator("multiBuyLineItems", typeof(commercetools.Sdk.HistoryApi.Models.ChangeValues.ChangeTargetMultiBuyLineItemsChangeValue))]
    [SubTypeDiscriminator("shipping", typeof(commercetools.Sdk.HistoryApi.Models.ChangeValues.ChangeTargetShippingChangeValue))]
    public partial interface IChangeTargetChangeValue
    {
        string Type { get; set; }
    }
}
