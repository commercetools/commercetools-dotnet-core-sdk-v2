using commercetools.Sdk.Api.Models.Orders;


namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class DeliveryAddedMessagePayload : IDeliveryAddedMessagePayload
    {
        public string Type { get; set; }

        public IDelivery Delivery { get; set; }

        public string ShippingKey { get; set; }
        public DeliveryAddedMessagePayload()
        {
            this.Type = "DeliveryAdded";
        }
    }
}
