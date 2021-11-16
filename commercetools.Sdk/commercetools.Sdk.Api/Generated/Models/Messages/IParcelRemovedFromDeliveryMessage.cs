using commercetools.Api.Models.Orders;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Api.Models.Messages.ParcelRemovedFromDeliveryMessage))]
    public partial interface IParcelRemovedFromDeliveryMessage : IMessage
    {
        string DeliveryId { get; set; }

        IParcel Parcel { get; set; }
    }
}
