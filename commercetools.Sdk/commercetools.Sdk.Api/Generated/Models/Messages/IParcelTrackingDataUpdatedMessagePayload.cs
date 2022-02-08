using commercetools.Api.Models.Orders;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Api.Models.Messages.ParcelTrackingDataUpdatedMessagePayload))]
    public partial interface IParcelTrackingDataUpdatedMessagePayload : IOrderMessagePayload
    {
        string DeliveryId { get; set; }

        string ParcelId { get; set; }

        ITrackingData TrackingData { get; set; }
    }
}
