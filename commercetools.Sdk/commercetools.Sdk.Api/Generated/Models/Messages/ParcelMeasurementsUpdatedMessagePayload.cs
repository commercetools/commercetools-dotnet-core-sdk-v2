using commercetools.Api.Models.Messages;
using commercetools.Api.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    public partial class ParcelMeasurementsUpdatedMessagePayload : IParcelMeasurementsUpdatedMessagePayload
    {
        public string Type { get; set;}
        
        public string DeliveryId { get; set;}
        
        public string ParcelId { get; set;}
        
        public IParcelMeasurements Measurements { get; set;}
        public ParcelMeasurementsUpdatedMessagePayload()
        { 
           this.Type = "ParcelMeasurementsUpdated";
        }
    }
}
