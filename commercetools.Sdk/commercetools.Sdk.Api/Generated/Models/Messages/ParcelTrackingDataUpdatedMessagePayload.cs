using commercetools.Sdk.Api.Models.Orders;


namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class ParcelTrackingDataUpdatedMessagePayload : IParcelTrackingDataUpdatedMessagePayload
    {
        public string Type { get; set; }

        public string DeliveryId { get; set; }

        public string ParcelId { get; set; }

        public ITrackingData TrackingData { get; set; }
        public ParcelTrackingDataUpdatedMessagePayload()
        {
            this.Type = "ParcelTrackingDataUpdated";
        }
    }
}
