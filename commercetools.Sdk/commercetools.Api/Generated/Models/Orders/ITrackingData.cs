using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Generated.Models.Orders
{
    public interface ITrackingData 
    {
        string TrackingId { get; set;}
        
        string Carrier { get; set;}
        
        string Provider { get; set;}
        
        string ProviderTransaction { get; set;}
        
        bool IsReturn { get; set;}
    }
}
