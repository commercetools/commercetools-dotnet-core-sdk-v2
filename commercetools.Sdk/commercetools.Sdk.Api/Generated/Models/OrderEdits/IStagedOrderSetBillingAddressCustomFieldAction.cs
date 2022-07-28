using commercetools.Sdk.Api.Models.Orders;
using System;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.OrderEdits
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.OrderEdits.StagedOrderSetBillingAddressCustomFieldAction))]
    public partial interface IStagedOrderSetBillingAddressCustomFieldAction : IStagedOrderUpdateAction
    {
        string Name { get; set; }

        Object Value { get; set; }

    }
}
