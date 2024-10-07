using System;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.DeliveryCustomFieldAddedMessagePayload))]
    public partial interface IDeliveryCustomFieldAddedMessagePayload : IOrderMessagePayload
    {
        string Name { get; set; }

        Object Value { get; set; }

        string DeliveryId { get; set; }

    }
}
