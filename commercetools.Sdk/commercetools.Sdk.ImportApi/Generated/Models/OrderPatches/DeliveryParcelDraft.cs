using commercetools.ImportApi.Models.Orders;
using System.Collections.Generic;


namespace commercetools.ImportApi.Models.OrderPatches
{
    public partial class DeliveryParcelDraft : IDeliveryParcelDraft
    {
        public IParcelMeasurements Measurements { get; set; }

        public ITrackingData TrackingData { get; set; }

        public List<IDeliveryItem> Items { get; set; }
    }
}
