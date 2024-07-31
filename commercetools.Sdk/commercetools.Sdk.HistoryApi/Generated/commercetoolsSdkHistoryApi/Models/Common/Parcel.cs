using System.Collections.Generic;
using System.Linq;

namespace commercetools.Sdk.HistoryApi.Models.Common
{

    public partial class Parcel : IParcel
    {
        public string Id { get; set; }

        public string CreatedAt { get; set; }

        public IParcelMeasurements Measurements { get; set; }

        public ITrackingData TrackingData { get; set; }

        public IList<IDeliveryItem> Items { get; set; }

        public IEnumerable<IDeliveryItem> ItemsEnumerable { set => Items = value.ToList(); }
    }
}
