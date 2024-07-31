using System;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.OrderCustomFieldAddedMessagePayload))]
    public partial interface IOrderCustomFieldAddedMessagePayload : IOrderMessagePayload
    {
        string Name { get; set; }

        Object Value { get; set; }

    }
}
