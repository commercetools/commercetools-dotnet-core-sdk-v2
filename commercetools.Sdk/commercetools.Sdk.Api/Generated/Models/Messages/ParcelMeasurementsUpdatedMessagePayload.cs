using commercetools.Api.Models.Orders;


namespace commercetools.Api.Models.Messages
{
    public partial class ParcelMeasurementsUpdatedMessagePayload : IParcelMeasurementsUpdatedMessagePayload
    {
        public string Type { get; set; }

        public string DeliveryId { get; set; }

        public string ParcelId { get; set; }

        public IParcelMeasurements Measurements { get; set; }
        public ParcelMeasurementsUpdatedMessagePayload()
        {
            this.Type = "ParcelMeasurementsUpdated";
        }
    }
}
