using commercetools.Sdk.Api.Models.Orders;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.OrderEdits
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.OrderEdits.StagedOrderSetParcelTrackingDataAction))]
    public partial interface IStagedOrderSetParcelTrackingDataAction : IStagedOrderUpdateAction
    {
        string ParcelId { get; set; }

        string ParcelKey { get; set; }

        ITrackingData TrackingData { get; set; }

    }
}
