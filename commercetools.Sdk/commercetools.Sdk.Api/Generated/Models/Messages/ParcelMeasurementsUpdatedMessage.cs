using commercetools.Api.Models.Messages;
using commercetools.Api.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    [DiscriminatorValue("ParcelMeasurementsUpdated")]
    public partial class ParcelMeasurementsUpdatedMessage : Message
    {
        public string DeliveryId { get; set;}
        
        public string ParcelId { get; set;}
        
        public ParcelMeasurements Measurements { get; set;}
        public ParcelMeasurementsUpdatedMessage()
        { 
           this.Type = "ParcelMeasurementsUpdated";
        }
    }
}
