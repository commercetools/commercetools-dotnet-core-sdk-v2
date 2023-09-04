using System;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.CustomerCustomFieldChangedMessage))]
    public partial interface ICustomerCustomFieldChangedMessage : IMessage
    {
        string Name { get; set; }

        Object Value { get; set; }

        Object PreviousValue { get; set; }

    }
}
