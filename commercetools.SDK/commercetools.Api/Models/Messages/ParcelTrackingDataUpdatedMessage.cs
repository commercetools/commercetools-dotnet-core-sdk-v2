using commercetools.Api.Models.Messages;
using commercetools.Api.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    [DiscriminatorValue("ParcelTrackingDataUpdated")]
    public partial class ParcelTrackingDataUpdatedMessage : Message
    {
        public string DeliveryId { get; set;}
        
        public string ParcelId { get; set;}
        
        public TrackingData TrackingData { get; set;}
        public ParcelTrackingDataUpdatedMessage()
        { 
           this.Type = "ParcelTrackingDataUpdated";
        }
    }
}
