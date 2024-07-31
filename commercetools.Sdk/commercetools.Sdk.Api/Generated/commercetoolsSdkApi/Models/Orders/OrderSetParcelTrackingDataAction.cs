

namespace commercetools.Sdk.Api.Models.Orders
{

    public partial class OrderSetParcelTrackingDataAction : IOrderSetParcelTrackingDataAction
    {
        public string Action { get; set; }

        public string ParcelId { get; set; }

        public string ParcelKey { get; set; }

        public ITrackingData TrackingData { get; set; }
        public OrderSetParcelTrackingDataAction()
        {
            this.Action = "setParcelTrackingData";
        }
    }
}
