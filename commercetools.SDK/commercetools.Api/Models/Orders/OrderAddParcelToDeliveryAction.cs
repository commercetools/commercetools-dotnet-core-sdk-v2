using commercetools.Api.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Orders
{
    [DiscriminatorValue("addParcelToDelivery")]
    public partial class OrderAddParcelToDeliveryAction : OrderUpdateAction
    {
        public string DeliveryId { get; set;}
        
        public ParcelMeasurements Measurements { get; set;}
        
        public TrackingData TrackingData { get; set;}
        
        public List<DeliveryItem> Items { get; set;}
        public OrderAddParcelToDeliveryAction()
        { 
           this.Action = "addParcelToDelivery";
        }
    }
}
