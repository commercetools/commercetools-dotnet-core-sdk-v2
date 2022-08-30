using commercetools.Sdk.Api.Models.Orders;


namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class ParcelRemovedFromDeliveryMessagePayload : IParcelRemovedFromDeliveryMessagePayload
    {
        public string Type { get; set; }

        public string DeliveryId { get; set; }

        public IParcel Parcel { get; set; }

        public string ShippingKey { get; set; }
        public ParcelRemovedFromDeliveryMessagePayload()
        {
            this.Type = "ParcelRemovedFromDelivery";
        }
    }
}
