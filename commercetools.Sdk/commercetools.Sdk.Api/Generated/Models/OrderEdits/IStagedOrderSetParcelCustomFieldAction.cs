using commercetools.Api.Models.Orders;
using System;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.OrderEdits
{
    [DeserializeAs(typeof(commercetools.Api.Models.OrderEdits.StagedOrderSetParcelCustomFieldAction))]
    public partial interface IStagedOrderSetParcelCustomFieldAction : IStagedOrderUpdateAction
    {
        string ParcelId { get; set; }

        string Name { get; set; }

        Object Value { get; set; }
    }
}
