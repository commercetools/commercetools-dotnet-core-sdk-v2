using commercetools.Api.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.OrderEdits
{
    [DiscriminatorValue("setDeliveryItems")]
    public class StagedOrderSetDeliveryItemsAction : StagedOrderUpdateAction
    {
        public string DeliveryId { get; set;}
        
        public List<DeliveryItem> Items { get; set;}
    }
}
