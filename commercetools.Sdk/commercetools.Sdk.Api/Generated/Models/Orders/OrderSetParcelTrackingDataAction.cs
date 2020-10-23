using commercetools.Api.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Orders
{
    public  partial class OrderSetParcelTrackingDataAction : IOrderSetParcelTrackingDataAction
    {
        public string Action { get; set;}
        
        public string ParcelId { get; set;}
        
        public ITrackingData TrackingData { get; set;}
        public OrderSetParcelTrackingDataAction()
        { 
           this.Action = "setParcelTrackingData";
        }
    }
}
