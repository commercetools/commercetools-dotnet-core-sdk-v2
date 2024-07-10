using System;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
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

        static commercetools.Sdk.HistoryApi.Models.ChangeValues.ChangeTargetCustomLineItemsChangeValue CustomLineItems(Action<commercetools.Sdk.HistoryApi.Models.ChangeValues.ChangeTargetCustomLineItemsChangeValue> init = null)
        {
            var t = new commercetools.Sdk.HistoryApi.Models.ChangeValues.ChangeTargetCustomLineItemsChangeValue();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.HistoryApi.Models.ChangeValues.ChangeTargetLineItemsChangeValue LineItems(Action<commercetools.Sdk.HistoryApi.Models.ChangeValues.ChangeTargetLineItemsChangeValue> init = null)
        {
            var t = new commercetools.Sdk.HistoryApi.Models.ChangeValues.ChangeTargetLineItemsChangeValue();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.HistoryApi.Models.ChangeValues.ChangeTargetMultiBuyCustomLineItemsChangeValue MultiBuyCustomLineItems(Action<commercetools.Sdk.HistoryApi.Models.ChangeValues.ChangeTargetMultiBuyCustomLineItemsChangeValue> init = null)
        {
            var t = new commercetools.Sdk.HistoryApi.Models.ChangeValues.ChangeTargetMultiBuyCustomLineItemsChangeValue();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.HistoryApi.Models.ChangeValues.ChangeTargetMultiBuyLineItemsChangeValue MultiBuyLineItems(Action<commercetools.Sdk.HistoryApi.Models.ChangeValues.ChangeTargetMultiBuyLineItemsChangeValue> init = null)
        {
            var t = new commercetools.Sdk.HistoryApi.Models.ChangeValues.ChangeTargetMultiBuyLineItemsChangeValue();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.HistoryApi.Models.ChangeValues.ChangeTargetShippingChangeValue Shipping(Action<commercetools.Sdk.HistoryApi.Models.ChangeValues.ChangeTargetShippingChangeValue> init = null)
        {
            var t = new commercetools.Sdk.HistoryApi.Models.ChangeValues.ChangeTargetShippingChangeValue();
            init?.Invoke(t);
            return t;
        }
    }
}
