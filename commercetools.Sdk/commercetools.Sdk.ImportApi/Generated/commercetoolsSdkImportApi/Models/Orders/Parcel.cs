using commercetools.Sdk.ImportApi.Models.Customfields;
using System;
using System.Collections.Generic;
using System.Linq;


namespace commercetools.Sdk.ImportApi.Models.Orders
{

    public partial class Parcel : IParcel
    {
        public string Id { get; set; }

        public DateTime CreatedAt { get; set; }

        public IParcelMeasurements Measurements { get; set; }

        public ITrackingData TrackingData { get; set; }

        public IList<IDeliveryItem> Items { get; set; }
        public IEnumerable<IDeliveryItem> ItemsEnumerable { set => Items = value.ToList(); }


        public ICustom Custom { get; set; }
    }
}
