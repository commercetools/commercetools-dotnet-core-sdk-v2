using commercetools.Api.Models.Messages;
using commercetools.Api.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    [DiscriminatorValue("ParcelTrackingDataUpdated")]
    public partial class ParcelTrackingDataUpdatedMessagePayload : MessagePayload
    {
        public string DeliveryId { get; set;}
        
        public string ParcelId { get; set;}
        
        public TrackingData TrackingData { get; set;}
        public ParcelTrackingDataUpdatedMessagePayload()
        { 
           this.Type = "ParcelTrackingDataUpdated";
        }
    }
}
