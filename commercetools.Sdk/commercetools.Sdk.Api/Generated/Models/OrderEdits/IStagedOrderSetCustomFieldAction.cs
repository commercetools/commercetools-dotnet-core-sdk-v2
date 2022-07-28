using commercetools.Sdk.Api.Models.Orders;
using System;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.OrderEdits
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.OrderEdits.StagedOrderSetCustomFieldAction))]
    public partial interface IStagedOrderSetCustomFieldAction : IStagedOrderUpdateAction
    {
        string Name { get; set; }

        Object Value { get; set; }

    }
}
