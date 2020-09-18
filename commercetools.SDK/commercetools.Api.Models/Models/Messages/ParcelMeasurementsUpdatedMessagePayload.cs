using commercetools.Api.Models.Messages;
using commercetools.Api.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    [DiscriminatorValue("ParcelMeasurementsUpdated")]
    public class ParcelMeasurementsUpdatedMessagePayload : MessagePayload
    {
        public string DeliveryId { get; set;}
        
        public string ParcelId { get; set;}
        
        public ParcelMeasurements Measurements { get; set;}
    }
}
