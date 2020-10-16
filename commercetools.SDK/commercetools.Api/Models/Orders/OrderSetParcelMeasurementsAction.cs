using commercetools.Api.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Orders
{
    [DiscriminatorValue("setParcelMeasurements")]
    public partial class OrderSetParcelMeasurementsAction : OrderUpdateAction
    {
        public string ParcelId { get; set;}
        
        public ParcelMeasurements Measurements { get; set;}
        public OrderSetParcelMeasurementsAction()
        { 
           this.Action = "setParcelMeasurements";
        }
    }
}
