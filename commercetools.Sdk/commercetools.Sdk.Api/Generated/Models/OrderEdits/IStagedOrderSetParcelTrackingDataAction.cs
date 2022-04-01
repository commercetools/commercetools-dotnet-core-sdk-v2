using commercetools.Sdk.Api.Models.Orders;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.OrderEdits
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.OrderEdits.StagedOrderSetParcelTrackingDataAction))]
    public partial interface IStagedOrderSetParcelTrackingDataAction : IStagedOrderUpdateAction
    {
        string ParcelId { get; set; }

        ITrackingData TrackingData { get; set; }
    }
}
