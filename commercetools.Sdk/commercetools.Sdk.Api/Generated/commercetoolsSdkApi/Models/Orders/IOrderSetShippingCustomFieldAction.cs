using System;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Orders
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Orders.OrderSetShippingCustomFieldAction))]
    public partial interface IOrderSetShippingCustomFieldAction : IOrderUpdateAction
    {
        string ShippingKey { get; set; }

        string Name { get; set; }

        Object Value { get; set; }

    }
}
