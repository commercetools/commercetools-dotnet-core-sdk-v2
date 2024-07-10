using commercetools.Sdk.ImportApi.Models.Orders;
using System.Collections.Generic;
using System.Linq;


namespace commercetools.Sdk.ImportApi.Models.OrderPatches
{

    public partial class DeliveryParcel : IDeliveryParcel
    {
        public string DeliveryId { get; set; }

        public IParcelMeasurements Measurements { get; set; }

        public ITrackingData TrackingData { get; set; }

        public IList<IDeliveryItem> Items { get; set; }
        public IEnumerable<IDeliveryItem> ItemsEnumerable { set => Items = value.ToList(); }

    }
}
