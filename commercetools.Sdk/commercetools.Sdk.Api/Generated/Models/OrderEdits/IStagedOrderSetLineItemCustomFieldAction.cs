using commercetools.Sdk.Api.Models.Orders;
using System;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.OrderEdits
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.OrderEdits.StagedOrderSetLineItemCustomFieldAction))]
    public partial interface IStagedOrderSetLineItemCustomFieldAction : IStagedOrderUpdateAction
    {
        string LineItemId { get; set; }

        string LineItemKey { get; set; }

        string Name { get; set; }

        Object Value { get; set; }

    }
}
