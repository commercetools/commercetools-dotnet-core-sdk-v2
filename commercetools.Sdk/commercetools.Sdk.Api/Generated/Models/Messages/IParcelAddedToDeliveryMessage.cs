using commercetools.Api.Models.Orders;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Api.Models.Messages.ParcelAddedToDeliveryMessage))]
    public partial interface IParcelAddedToDeliveryMessage : IOrderMessage
    {
        IDelivery Delivery { get; set; }

        IParcel Parcel { get; set; }
    }
}
