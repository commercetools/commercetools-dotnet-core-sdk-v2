using commercetools.Api.Models.Orders;


namespace commercetools.Api.Models.Messages
{
    public partial class ParcelTrackingDataUpdatedMessagePayload : IParcelTrackingDataUpdatedMessagePayload
    {
        public string Type { get; set;}
        
        public string DeliveryId { get; set;}
        
        public string ParcelId { get; set;}
        
        public ITrackingData TrackingData { get; set;}
        public ParcelTrackingDataUpdatedMessagePayload()
        { 
           this.Type = "ParcelTrackingDataUpdated";
        }
    }
}
