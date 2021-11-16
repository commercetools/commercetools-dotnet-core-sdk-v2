using System.Collections.Generic;


namespace commercetools.HistoryApi.Models.Common
{
    public partial class Parcel : IParcel
    {
        public string Id { get; set;}
        
        public string CreatedAt { get; set;}
        
        public IParcelMeasurements Measurements { get; set;}
        
        public ITrackingData TrackingData { get; set;}
        
        public List<IDeliveryItem> Items { get; set;}
    }
}
