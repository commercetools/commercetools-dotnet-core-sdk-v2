using commercetools.Sdk.Api.Models.Orders;
using System;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.OrderEdits
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.OrderEdits.StagedOrderSetParcelCustomFieldAction))]
    public partial interface IStagedOrderSetParcelCustomFieldAction : IStagedOrderUpdateAction
    {
        string ParcelId { get; set; }

        string ParcelKey { get; set; }

        string Name { get; set; }

        Object Value { get; set; }

    }
}
