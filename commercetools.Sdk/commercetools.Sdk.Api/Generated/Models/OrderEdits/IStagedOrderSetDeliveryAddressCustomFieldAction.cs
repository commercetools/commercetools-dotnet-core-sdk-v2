using commercetools.Sdk.Api.Models.Orders;
using System;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.OrderEdits
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.OrderEdits.StagedOrderSetDeliveryAddressCustomFieldAction))]
    public partial interface IStagedOrderSetDeliveryAddressCustomFieldAction : IStagedOrderUpdateAction
    {
        string DeliveryId { get; set; }

        string Name { get; set; }

        Object Value { get; set; }

    }
}
