using commercetools.Api.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.Orders
{
    [DiscriminatorValue("setDeliveryItems")]
    public partial class OrderSetDeliveryItemsAction : OrderUpdateAction
    {
        public string DeliveryId { get; set;}
        
        public List<DeliveryItem> Items { get; set;}
        public OrderSetDeliveryItemsAction()
        { 
           this.Action = "setDeliveryItems";
        }
    }
}
