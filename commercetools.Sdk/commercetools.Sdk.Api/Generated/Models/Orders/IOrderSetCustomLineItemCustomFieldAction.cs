using System;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Orders
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Orders.OrderSetCustomLineItemCustomFieldAction))]
    public partial interface IOrderSetCustomLineItemCustomFieldAction : IOrderUpdateAction
    {
        string CustomLineItemId { get; set; }

        string Name { get; set; }

        Object Value { get; set; }

    }
}
