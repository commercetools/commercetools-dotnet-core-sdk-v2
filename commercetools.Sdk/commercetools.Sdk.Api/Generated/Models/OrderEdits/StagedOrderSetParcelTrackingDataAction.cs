using commercetools.Sdk.Api.Models.Orders;


namespace commercetools.Sdk.Api.Models.OrderEdits
{
    public partial class StagedOrderSetParcelTrackingDataAction : IStagedOrderSetParcelTrackingDataAction
    {
        public string Action { get; set; }

        public string ParcelId { get; set; }

        public ITrackingData TrackingData { get; set; }
        public StagedOrderSetParcelTrackingDataAction()
        {
            this.Action = "setParcelTrackingData";
        }
    }
}
