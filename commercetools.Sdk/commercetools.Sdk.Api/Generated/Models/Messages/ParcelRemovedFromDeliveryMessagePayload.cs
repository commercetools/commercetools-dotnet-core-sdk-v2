using commercetools.Api.Models.Orders;


namespace commercetools.Api.Models.Messages
{
    public partial class ParcelRemovedFromDeliveryMessagePayload : IParcelRemovedFromDeliveryMessagePayload
    {
        public string Type { get; set;}
        
        public string DeliveryId { get; set;}
        
        public IParcel Parcel { get; set;}
        public ParcelRemovedFromDeliveryMessagePayload()
        { 
           this.Type = "ParcelRemovedFromDelivery";
        }
    }
}
