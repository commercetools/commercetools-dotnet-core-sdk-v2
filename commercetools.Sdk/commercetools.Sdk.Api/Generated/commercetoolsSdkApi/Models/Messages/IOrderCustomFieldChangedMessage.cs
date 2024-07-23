using System;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.OrderCustomFieldChangedMessage))]
    public partial interface IOrderCustomFieldChangedMessage : IOrderMessage
    {
        string Name { get; set; }

        Object Value { get; set; }

        Object PreviousValue { get; set; }

    }
}
