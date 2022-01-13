using commercetools.Api.Models.Orders;
using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.OrderEdits
{
    [DeserializeAs(typeof(commercetools.Api.Models.OrderEdits.StagedOrderSetDeliveryItemsAction))]
    public partial interface IStagedOrderSetDeliveryItemsAction : IStagedOrderUpdateAction
    {
        string DeliveryId { get; set; }

        List<IDeliveryItem> Items { get; set; }
    }
}
