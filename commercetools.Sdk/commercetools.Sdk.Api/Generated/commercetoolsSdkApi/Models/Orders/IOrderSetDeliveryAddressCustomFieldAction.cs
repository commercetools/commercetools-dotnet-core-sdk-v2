using System;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Orders
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Orders.OrderSetDeliveryAddressCustomFieldAction))]
    public partial interface IOrderSetDeliveryAddressCustomFieldAction : IOrderUpdateAction
    {
        string DeliveryId { get; set; }

        string DeliveryKey { get; set; }

        string Name { get; set; }

        Object Value { get; set; }

    }
}
