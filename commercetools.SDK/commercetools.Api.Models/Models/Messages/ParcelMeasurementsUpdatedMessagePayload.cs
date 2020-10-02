using commercetools.Api.Models.Messages;
using commercetools.Api.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    [DiscriminatorValue("ParcelMeasurementsUpdated")]
    public partial class ParcelMeasurementsUpdatedMessagePayload : MessagePayload
    {
        public string DeliveryId { get; set;}
        
        public string ParcelId { get; set;}
        
        public ParcelMeasurements Measurements { get; set;}
        public ParcelMeasurementsUpdatedMessagePayload()
        { 
           this.Type = "ParcelMeasurementsUpdated";
        }
    }
}
