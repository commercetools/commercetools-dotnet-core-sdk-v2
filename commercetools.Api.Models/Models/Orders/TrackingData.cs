using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.Orders
{
    public class TrackingData 
    {
        public string TrackingId { get; set;}
        
        public string Carrier { get; set;}
        
        public string Provider { get; set;}
        
        public string ProviderTransaction { get; set;}
        
        public bool IsReturn { get; set;}
    }
}
