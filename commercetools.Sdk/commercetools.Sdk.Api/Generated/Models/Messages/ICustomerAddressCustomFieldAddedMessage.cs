using System;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.CustomerAddressCustomFieldAddedMessage))]
    public partial interface ICustomerAddressCustomFieldAddedMessage : IMessage
    {
        string Name { get; set; }

        Object Value { get; set; }

    }
}
