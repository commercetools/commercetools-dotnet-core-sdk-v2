using commercetools.ImportApi.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.ImportApi.Models.OrderPatches
{
    public partial class ParcelTrackingData : IParcelTrackingData
    {
        public string ParcelId { get; set;}
        
        public ITrackingData TrackingData { get; set;}
    }
}
