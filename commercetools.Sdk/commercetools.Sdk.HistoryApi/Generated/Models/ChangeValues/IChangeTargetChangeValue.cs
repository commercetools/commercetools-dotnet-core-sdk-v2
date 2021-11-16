using commercetools.Base.CustomAttributes;


namespace commercetools.HistoryApi.Models.ChangeValues
{
    [TypeDiscriminator(nameof(Type))]
    [DefaultTypeDiscriminator(typeof(commercetools.HistoryApi.Models.ChangeValues.ChangeTargetChangeValue))]
    [SubTypeDiscriminator("customLineItems", typeof(commercetools.HistoryApi.Models.ChangeValues.ChangeTargetCustomLineItemsChangeValue))]
    [SubTypeDiscriminator("lineItems", typeof(commercetools.HistoryApi.Models.ChangeValues.ChangeTargetLineItemsChangeValue))]
    [SubTypeDiscriminator("multiBuyCustomLineItems", typeof(commercetools.HistoryApi.Models.ChangeValues.ChangeTargetMultiBuyCustomLineItemsChangeValue))]
    [SubTypeDiscriminator("multiBuyLineItems", typeof(commercetools.HistoryApi.Models.ChangeValues.ChangeTargetMultiBuyLineItemsChangeValue))]
    [SubTypeDiscriminator("shipping", typeof(commercetools.HistoryApi.Models.ChangeValues.ChangeTargetShippingChangeValue))]
    public partial interface IChangeTargetChangeValue
    {
        string Type { get; set; }
    }
}
