using commercetools.Api.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.Orders
{
    [DiscriminatorValue("setParcelTrackingData")]
    public class OrderSetParcelTrackingDataAction : OrderUpdateAction
    {
        public string ParcelId { get; set;}
        
        public TrackingData TrackingData { get; set;}
    }
}
