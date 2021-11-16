using commercetools.Api.Models.Orders;


namespace commercetools.Api.Models.Messages
{
    public partial class ParcelAddedToDeliveryMessagePayload : IParcelAddedToDeliveryMessagePayload
    {
        public string Type { get; set; }

        public IDelivery Delivery { get; set; }

        public IParcel Parcel { get; set; }
        public ParcelAddedToDeliveryMessagePayload()
        {
            this.Type = "ParcelAddedToDelivery";
        }
    }
}
