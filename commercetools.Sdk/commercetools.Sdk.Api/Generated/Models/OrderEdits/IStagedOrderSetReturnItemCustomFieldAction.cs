using commercetools.Api.Models.Orders;
using System;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.OrderEdits
{
    [DeserializeAs(typeof(commercetools.Api.Models.OrderEdits.StagedOrderSetReturnItemCustomFieldAction))]
    public partial interface IStagedOrderSetReturnItemCustomFieldAction : IStagedOrderUpdateAction
    {
        string ReturnItemId { get; set; }

        string Name { get; set; }

        Object Value { get; set; }
    }
}
