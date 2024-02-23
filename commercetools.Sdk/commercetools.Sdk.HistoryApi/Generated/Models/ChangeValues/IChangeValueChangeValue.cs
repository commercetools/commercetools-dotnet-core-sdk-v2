using System;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
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

        static commercetools.Sdk.HistoryApi.Models.ChangeValues.ChangeValueAbsoluteChangeValue Absolute(Action<commercetools.Sdk.HistoryApi.Models.ChangeValues.ChangeValueAbsoluteChangeValue> init = null)
        {
            var t = new commercetools.Sdk.HistoryApi.Models.ChangeValues.ChangeValueAbsoluteChangeValue();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.HistoryApi.Models.ChangeValues.ChangeValueExternalChangeValue External(Action<commercetools.Sdk.HistoryApi.Models.ChangeValues.ChangeValueExternalChangeValue> init = null)
        {
            var t = new commercetools.Sdk.HistoryApi.Models.ChangeValues.ChangeValueExternalChangeValue();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.HistoryApi.Models.ChangeValues.ChangeValueGiftLineItemChangeValue GiftLineItem(Action<commercetools.Sdk.HistoryApi.Models.ChangeValues.ChangeValueGiftLineItemChangeValue> init = null)
        {
            var t = new commercetools.Sdk.HistoryApi.Models.ChangeValues.ChangeValueGiftLineItemChangeValue();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.HistoryApi.Models.ChangeValues.ChangeValueRelativeChangeValue Relative(Action<commercetools.Sdk.HistoryApi.Models.ChangeValues.ChangeValueRelativeChangeValue> init = null)
        {
            var t = new commercetools.Sdk.HistoryApi.Models.ChangeValues.ChangeValueRelativeChangeValue();
            init?.Invoke(t);
            return t;
        }
    }
}
