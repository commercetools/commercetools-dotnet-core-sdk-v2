using commercetools.Sdk.ImportApi.Models.Orders;
using System.Collections.Generic;


namespace commercetools.Sdk.ImportApi.Models.OrderPatches
{

    public partial class DeliveryParcelDraft : IDeliveryParcelDraft
    {
        public IParcelMeasurements Measurements { get; set; }

        public ITrackingData TrackingData { get; set; }

        public List<IDeliveryItem> Items { get; set; }
    }
}
