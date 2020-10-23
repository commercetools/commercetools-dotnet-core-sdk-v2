using commercetools.Api.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.OrderEdits
{
    public  partial class StagedOrderSetParcelMeasurementsAction : IStagedOrderSetParcelMeasurementsAction
    {
        public string Action { get; set;}
        
        public string ParcelId { get; set;}
        
        public IParcelMeasurements Measurements { get; set;}
        public StagedOrderSetParcelMeasurementsAction()
        { 
           this.Action = "setParcelMeasurements";
        }
    }
}
