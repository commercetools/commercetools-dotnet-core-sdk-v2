using System;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.CustomerCustomFieldChangedMessagePayload))]
    public partial interface ICustomerCustomFieldChangedMessagePayload : IMessagePayload
    {
        string Name { get; set; }

        Object Value { get; set; }

        Object PreviousValue { get; set; }

    }
}
