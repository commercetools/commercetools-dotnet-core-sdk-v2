using commercetools.Sdk.Api.Models.Orders;
using System;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.OrderEdits
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.OrderEdits.StagedOrderSetCustomLineItemCustomFieldAction))]
    public partial interface IStagedOrderSetCustomLineItemCustomFieldAction : IStagedOrderUpdateAction
    {
        string CustomLineItemId { get; set; }

        string Name { get; set; }

        Object Value { get; set; }

    }
}
