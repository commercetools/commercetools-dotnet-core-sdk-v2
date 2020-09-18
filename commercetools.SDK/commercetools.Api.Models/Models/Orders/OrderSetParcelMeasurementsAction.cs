using commercetools.Api.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.Orders
{
    [DiscriminatorValue("setParcelMeasurements")]
    public class OrderSetParcelMeasurementsAction : OrderUpdateAction
    {
        public string ParcelId { get; set;}
        
        public ParcelMeasurements Measurements { get; set;}
    }
}
