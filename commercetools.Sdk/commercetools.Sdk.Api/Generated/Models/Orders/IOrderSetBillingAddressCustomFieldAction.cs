using System;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Orders
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Orders.OrderSetBillingAddressCustomFieldAction))]
    public partial interface IOrderSetBillingAddressCustomFieldAction : IOrderUpdateAction
    {
        string Name { get; set; }

        Object Value { get; set; }

    }
}
