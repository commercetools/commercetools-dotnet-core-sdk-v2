using commercetools.Api.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Orders
{
    [DiscriminatorValue("setParcelTrackingData")]
    public partial class OrderSetParcelTrackingDataAction : OrderUpdateAction
    {
        public string ParcelId { get; set;}
        
        public TrackingData TrackingData { get; set;}
        public OrderSetParcelTrackingDataAction()
        { 
           this.Action = "setParcelTrackingData";
        }
    }
}
