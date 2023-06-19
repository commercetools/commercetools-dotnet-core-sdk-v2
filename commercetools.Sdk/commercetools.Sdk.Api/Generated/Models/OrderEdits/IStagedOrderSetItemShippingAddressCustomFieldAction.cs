using commercetools.Sdk.Api.Models.Orders;
using System;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.OrderEdits
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.OrderEdits.StagedOrderSetItemShippingAddressCustomFieldAction))]
    public partial interface IStagedOrderSetItemShippingAddressCustomFieldAction : IStagedOrderUpdateAction
    {
        string AddressKey { get; set; }

        string Name { get; set; }

        Object Value { get; set; }

    }
}
