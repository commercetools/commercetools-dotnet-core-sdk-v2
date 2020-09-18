using commercetools.Api.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.Orders
{
    public class Parcel 
    {
        public string Id { get; set;}
        
        public DateTime CreatedAt { get; set;}
        
        public ParcelMeasurements Measurements { get; set;}
        
        public TrackingData TrackingData { get; set;}
        
        public List<DeliveryItem> Items { get; set;}
    }
}
