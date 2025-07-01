using System;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.PaymentMethodCustomFieldChangedMessage))]
    public partial interface IPaymentMethodCustomFieldChangedMessage : IMessage
    {
        string Name { get; set; }

        Object Value { get; set; }

        Object OldValue { get; set; }

    }
}
