using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Orders
{
    public partial class TrackingData : ITrackingData
    {
        public string TrackingId { get; set;}
        
        public string Carrier { get; set;}
        
        public string Provider { get; set;}
        
        public string ProviderTransaction { get; set;}
        
        public bool? IsReturn { get; set;}
    }
}
