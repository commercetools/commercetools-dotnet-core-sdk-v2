using commercetools.Sdk.Api.Models.Types;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Sdk.Api.Models.Orders
{

    public partial class OrderAddParcelToDeliveryAction : IOrderAddParcelToDeliveryAction
    {
        public string Action { get; set; }

        public string DeliveryId { get; set; }

        public string DeliveryKey { get; set; }

        public string ParcelKey { get; set; }

        public IParcelMeasurements Measurements { get; set; }

        public ITrackingData TrackingData { get; set; }

        public IList<IDeliveryItem> Items { get; set; }

        public IEnumerable<IDeliveryItem> ItemsEnumerable { set => Items = value.ToList(); }

        public ICustomFieldsDraft Custom { get; set; }
        public OrderAddParcelToDeliveryAction()
        {
            this.Action = "addParcelToDelivery";
        }
    }
}
