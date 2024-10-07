using System;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.CustomerGroupCustomFieldChangedMessage))]
    public partial interface ICustomerGroupCustomFieldChangedMessage : IMessage
    {
        string Name { get; set; }

        Object Value { get; set; }

        Object OldValue { get; set; }

    }
}
