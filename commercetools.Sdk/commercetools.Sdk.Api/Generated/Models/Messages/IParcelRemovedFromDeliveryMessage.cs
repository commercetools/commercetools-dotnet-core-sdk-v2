using commercetools.Sdk.Api.Models.Orders;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.ParcelRemovedFromDeliveryMessage))]
    public partial interface IParcelRemovedFromDeliveryMessage : IOrderMessage
    {
        string DeliveryId { get; set; }

        IParcel Parcel { get; set; }

        string ShippingKey { get; set; }

    }
}
