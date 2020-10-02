using commercetools.Api.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.OrderEdits
{
    [DiscriminatorValue("setParcelMeasurements")]
    public partial class StagedOrderSetParcelMeasurementsAction : StagedOrderUpdateAction
    {
        public string ParcelId { get; set;}
        
        public ParcelMeasurements Measurements { get; set;}
        public StagedOrderSetParcelMeasurementsAction()
        { 
           this.Action = "setParcelMeasurements";
        }
    }
}
