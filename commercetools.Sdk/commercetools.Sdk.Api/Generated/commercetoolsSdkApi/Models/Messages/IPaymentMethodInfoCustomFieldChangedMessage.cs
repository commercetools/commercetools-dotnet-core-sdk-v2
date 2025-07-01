using System;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.PaymentMethodInfoCustomFieldChangedMessage))]
    public partial interface IPaymentMethodInfoCustomFieldChangedMessage : IMessage
    {
        string Name { get; set; }

        Object Value { get; set; }

    }
}
