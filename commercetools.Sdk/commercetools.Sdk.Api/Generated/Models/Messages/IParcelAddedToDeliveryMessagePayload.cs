using commercetools.Sdk.Api.Models.Orders;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.ParcelAddedToDeliveryMessagePayload))]
    public partial interface IParcelAddedToDeliveryMessagePayload : IOrderMessagePayload
    {
        IDelivery Delivery { get; set; }

        IParcel Parcel { get; set; }
    }
}
