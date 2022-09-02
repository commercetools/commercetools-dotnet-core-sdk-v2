using commercetools.Sdk.Api.Models.Orders;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.ParcelAddedToDeliveryMessage))]
    public partial interface IParcelAddedToDeliveryMessage : IOrderMessage
    {
        IDelivery Delivery { get; set; }

        IParcel Parcel { get; set; }

        string ShippingKey { get; set; }

    }
}
