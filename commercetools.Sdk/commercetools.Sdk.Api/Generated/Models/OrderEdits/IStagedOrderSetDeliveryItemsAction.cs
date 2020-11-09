using commercetools.Api.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.OrderEdits
{
    [DeserializeAs(typeof(commercetools.Api.Models.OrderEdits.StagedOrderSetDeliveryItemsAction))]
    public partial interface IStagedOrderSetDeliveryItemsAction : IStagedOrderUpdateAction
    {
        string DeliveryId { get; set;}
        
        List<IDeliveryItem> Items { get; set;}
    }
}
