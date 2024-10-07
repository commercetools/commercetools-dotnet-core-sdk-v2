using System;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.DeliveryCustomFieldAddedMessage))]
    public partial interface IDeliveryCustomFieldAddedMessage : IOrderMessage
    {
        string Name { get; set; }

        Object Value { get; set; }

        string DeliveryId { get; set; }

    }
}
