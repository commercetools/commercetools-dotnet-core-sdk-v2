using System;
using System.Collections.Generic;


namespace commercetools.Sdk.ImportApi.Models.Orders
{

    public partial class Parcel : IParcel
    {
        public string Id { get; set; }

        public DateTime CreatedAt { get; set; }

        public IParcelMeasurements Measurements { get; set; }

        public ITrackingData TrackingData { get; set; }

        public List<IDeliveryItem> Items { get; set; }
    }
}
