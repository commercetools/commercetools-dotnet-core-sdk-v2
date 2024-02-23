using commercetools.Sdk.Api.Models.Orders;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.ParcelTrackingDataUpdatedMessagePayload))]
    public partial interface IParcelTrackingDataUpdatedMessagePayload : IOrderMessagePayload
    {
        string DeliveryId { get; set; }

        string ParcelId { get; set; }

        ITrackingData TrackingData { get; set; }

        string ShippingKey { get; set; }

    }
}
