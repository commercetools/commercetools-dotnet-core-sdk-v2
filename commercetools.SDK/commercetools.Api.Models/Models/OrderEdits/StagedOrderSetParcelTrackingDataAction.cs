using commercetools.Api.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.OrderEdits
{
    [DiscriminatorValue("setParcelTrackingData")]
    public partial class StagedOrderSetParcelTrackingDataAction : StagedOrderUpdateAction
    {
        public string ParcelId { get; set;}
        
        public TrackingData TrackingData { get; set;}
        public StagedOrderSetParcelTrackingDataAction()
        { 
           this.Action = "setParcelTrackingData";
        }
    }
}
