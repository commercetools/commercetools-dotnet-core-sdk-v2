using commercetools.Api.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.Orders
{
    [DiscriminatorValue("setDeliveryItems")]
    public class OrderSetDeliveryItemsAction : OrderUpdateAction
    {
        public string DeliveryId { get; set;}
        
        public List<DeliveryItem> Items { get; set;}
    }
}
