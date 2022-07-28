using commercetools.Sdk.ImportApi.Models.Orders;
using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.ImportApi.Models.OrderPatches
{
    [DeserializeAs(typeof(commercetools.Sdk.ImportApi.Models.OrderPatches.DeliveryParcelDraft))]
    public partial interface IDeliveryParcelDraft
    {
        IParcelMeasurements Measurements { get; set; }

        ITrackingData TrackingData { get; set; }

        List<IDeliveryItem> Items { get; set; }

    }
}
