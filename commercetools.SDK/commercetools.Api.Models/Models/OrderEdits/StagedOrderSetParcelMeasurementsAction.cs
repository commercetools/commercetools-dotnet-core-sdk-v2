using commercetools.Api.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.OrderEdits
{
    [DiscriminatorValue("setParcelMeasurements")]
    public class StagedOrderSetParcelMeasurementsAction : StagedOrderUpdateAction
    {
        public string ParcelId { get; set;}
        
        public ParcelMeasurements Measurements { get; set;}
    }
}
