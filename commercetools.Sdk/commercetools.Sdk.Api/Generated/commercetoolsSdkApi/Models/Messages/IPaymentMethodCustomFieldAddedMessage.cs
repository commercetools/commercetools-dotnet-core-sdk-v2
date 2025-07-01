using System;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.PaymentMethodCustomFieldAddedMessage))]
    public partial interface IPaymentMethodCustomFieldAddedMessage : IMessage
    {
        string Name { get; set; }

        Object Value { get; set; }

    }
}
