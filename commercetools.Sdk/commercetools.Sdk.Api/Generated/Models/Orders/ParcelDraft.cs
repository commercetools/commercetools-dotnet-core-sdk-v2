using System.Collections.Generic;


namespace commercetools.Api.Models.Orders
{
    public partial class ParcelDraft : IParcelDraft
    {
        public IParcelMeasurements Measurements { get; set; }

        public ITrackingData TrackingData { get; set; }

        public List<IDeliveryItem> Items { get; set; }
    }
}
