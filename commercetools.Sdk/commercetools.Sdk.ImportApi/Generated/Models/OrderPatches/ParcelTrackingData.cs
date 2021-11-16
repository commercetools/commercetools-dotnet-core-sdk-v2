using commercetools.ImportApi.Models.Orders;


namespace commercetools.ImportApi.Models.OrderPatches
{
    public partial class ParcelTrackingData : IParcelTrackingData
    {
        public string ParcelId { get; set; }

        public ITrackingData TrackingData { get; set; }
    }
}
