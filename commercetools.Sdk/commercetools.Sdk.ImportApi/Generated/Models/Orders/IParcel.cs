using System;
using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.ImportApi.Models.Orders
{
    [DeserializeAs(typeof(commercetools.Sdk.ImportApi.Models.Orders.Parcel))]
    public partial interface IParcel
    {
        string Id { get; set; }

        DateTime CreatedAt { get; set; }

        IParcelMeasurements Measurements { get; set; }

        ITrackingData TrackingData { get; set; }

        List<IDeliveryItem> Items { get; set; }

    }
}
