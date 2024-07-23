using commercetools.Sdk.Api.Models.Orders;


namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class ParcelAddedToDeliveryMessagePayload : IParcelAddedToDeliveryMessagePayload
    {
        public string Type { get; set; }

        public IDelivery Delivery { get; set; }

        public IParcel Parcel { get; set; }

        public string ShippingKey { get; set; }
        public ParcelAddedToDeliveryMessagePayload()
        {
            this.Type = "ParcelAddedToDelivery";
        }
    }
}
