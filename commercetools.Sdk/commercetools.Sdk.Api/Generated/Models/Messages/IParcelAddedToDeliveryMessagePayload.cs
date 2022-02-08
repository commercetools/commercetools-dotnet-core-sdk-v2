using commercetools.Api.Models.Orders;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Api.Models.Messages.ParcelAddedToDeliveryMessagePayload))]
    public partial interface IParcelAddedToDeliveryMessagePayload : IOrderMessagePayload
    {
        IDelivery Delivery { get; set; }

        IParcel Parcel { get; set; }
    }
}
