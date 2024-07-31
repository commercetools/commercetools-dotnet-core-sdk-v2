using commercetools.Sdk.Api.Models.Types;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Sdk.Api.Models.Orders
{

    public partial class ParcelDraft : IParcelDraft
    {
        public string Key { get; set; }

        public IParcelMeasurements Measurements { get; set; }

        public ITrackingData TrackingData { get; set; }

        public IList<IDeliveryItem> Items { get; set; }

        public IEnumerable<IDeliveryItem> ItemsEnumerable { set => Items = value.ToList(); }

        public ICustomFieldsDraft Custom { get; set; }
    }
}
