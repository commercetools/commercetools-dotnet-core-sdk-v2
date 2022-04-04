using commercetools.Sdk.Api.Models.Types;
using System.Collections.Generic;


namespace commercetools.Sdk.Api.Models.Orders
{
    public partial class ParcelDraft : IParcelDraft
    {
        public IParcelMeasurements Measurements { get; set; }

        public ITrackingData TrackingData { get; set; }

        public List<IDeliveryItem> Items { get; set; }

        public ICustomFieldsDraft Custom { get; set; }
    }
}
