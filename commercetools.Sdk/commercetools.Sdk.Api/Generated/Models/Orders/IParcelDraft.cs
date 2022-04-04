using commercetools.Sdk.Api.Models.Types;
using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Orders
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Orders.ParcelDraft))]
    public partial interface IParcelDraft
    {
        IParcelMeasurements Measurements { get; set; }

        ITrackingData TrackingData { get; set; }

        List<IDeliveryItem> Items { get; set; }

        ICustomFieldsDraft Custom { get; set; }
    }
}
