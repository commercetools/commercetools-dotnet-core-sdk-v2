using commercetools.Api.Models.Orders;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Api.Models.Messages.ParcelRemovedFromDeliveryMessagePayload))]
    public partial interface IParcelRemovedFromDeliveryMessagePayload : IOrderMessagePayload
    {
        string DeliveryId { get; set; }

        IParcel Parcel { get; set; }
    }
}
