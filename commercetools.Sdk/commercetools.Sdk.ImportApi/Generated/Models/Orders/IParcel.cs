using commercetools.Sdk.ImportApi.Models.Customfields;
using System;
using System.Collections.Generic;
using System.Linq;
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

        IList<IDeliveryItem> Items { get; set; }
        IEnumerable<IDeliveryItem> ItemsEnumerable { set => Items = value.ToList(); }


        ICustom Custom { get; set; }

    }
}
