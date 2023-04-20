using commercetools.Sdk.Api.Models.Orders;
using System.Collections.Generic;
using System.Linq;


namespace commercetools.Sdk.Api.Models.OrderEdits
{

    public partial class StagedOrderAddParcelToDeliveryAction : IStagedOrderAddParcelToDeliveryAction
    {
        public string Action { get; set; }

        public string DeliveryId { get; set; }

        public string ParcelKey { get; set; }

        public IParcelMeasurements Measurements { get; set; }

        public ITrackingData TrackingData { get; set; }

        public IList<IDeliveryItem> Items { get; set; }
        public IEnumerable<IDeliveryItem> ItemsEnumerable { set => Items = value.ToList(); }

        public StagedOrderAddParcelToDeliveryAction()
        {
            this.Action = "addParcelToDelivery";
        }
    }
}
