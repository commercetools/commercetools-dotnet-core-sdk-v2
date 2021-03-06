using commercetools.Api.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.OrderEdits
{
    public partial class StagedOrderSetParcelTrackingDataAction : IStagedOrderSetParcelTrackingDataAction
    {
        public string Action { get; set;}
        
        public string ParcelId { get; set;}
        
        public ITrackingData TrackingData { get; set;}
        public StagedOrderSetParcelTrackingDataAction()
        { 
           this.Action = "setParcelTrackingData";
        }
    }
}
