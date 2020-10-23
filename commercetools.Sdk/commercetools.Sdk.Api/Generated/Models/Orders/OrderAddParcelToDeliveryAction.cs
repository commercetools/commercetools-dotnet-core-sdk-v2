using commercetools.Api.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Orders
{
    public  partial class OrderAddParcelToDeliveryAction : IOrderAddParcelToDeliveryAction
    {
        public string Action { get; set;}
        
        public string DeliveryId { get; set;}
        
        public IParcelMeasurements Measurements { get; set;}
        
        public ITrackingData TrackingData { get; set;}
        
        public List<IDeliveryItem> Items { get; set;}
        public OrderAddParcelToDeliveryAction()
        { 
           this.Action = "addParcelToDelivery";
        }
    }
}
