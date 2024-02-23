using System;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.CustomerCustomFieldAddedMessage))]
    public partial interface ICustomerCustomFieldAddedMessage : IMessage
    {
        string Name { get; set; }

        Object Value { get; set; }

    }
}
