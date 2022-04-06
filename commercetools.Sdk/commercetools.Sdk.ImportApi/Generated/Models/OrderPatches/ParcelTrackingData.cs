using commercetools.Sdk.ImportApi.Models.Orders;


namespace commercetools.Sdk.ImportApi.Models.OrderPatches
{
    public partial class ParcelTrackingData : IParcelTrackingData
    {
        public string ParcelId { get; set; }

        public ITrackingData TrackingData { get; set; }
    }
}
