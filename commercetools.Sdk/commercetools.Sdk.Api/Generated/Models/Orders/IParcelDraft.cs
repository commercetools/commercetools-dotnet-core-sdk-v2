using commercetools.Sdk.Api.Models.Types;
using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Orders
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Orders.ParcelDraft))]
    public partial interface IParcelDraft
    {
        IParcelMeasurements Measurements { get; set; }

        ITrackingData TrackingData { get; set; }

        IList<IDeliveryItem> Items { get; set; }
        IEnumerable<IDeliveryItem> ItemsEnumerable { set => Items = value.ToList(); }


        ICustomFieldsDraft Custom { get; set; }

        string Key { get; set; }

    }
}
