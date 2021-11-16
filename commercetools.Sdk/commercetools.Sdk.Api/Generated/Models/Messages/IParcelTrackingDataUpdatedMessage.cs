using commercetools.Api.Models.Orders;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Api.Models.Messages.ParcelTrackingDataUpdatedMessage))]
    public partial interface IParcelTrackingDataUpdatedMessage : IMessage
    {
        string DeliveryId { get; set;}
        
        string ParcelId { get; set;}
        
        ITrackingData TrackingData { get; set;}
    }
}
