using commercetools.Api.Models.Messages;
using commercetools.Api.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.Messages
{
    public class ParcelTrackingDataUpdatedMessage : Message
    {
        public string DeliveryId { get; set;}
        
        public string ParcelId { get; set;}
        
        public TrackingData TrackingData { get; set;}
    }
}
