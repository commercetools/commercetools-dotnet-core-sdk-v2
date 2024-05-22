using commercetools.Sdk.Api.Models.Orders;
using System;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.OrderEdits
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.OrderEdits.StagedOrderSetShippingCustomFieldAction))]
    public partial interface IStagedOrderSetShippingCustomFieldAction : IStagedOrderUpdateAction
    {
        string ShippingKey { get; set; }

        string Name { get; set; }

        Object Value { get; set; }

    }
}
