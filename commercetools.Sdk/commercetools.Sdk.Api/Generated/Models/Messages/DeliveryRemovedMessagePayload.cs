using commercetools.Sdk.Api.Models.Orders;


namespace commercetools.Sdk.Api.Models.Messages
{
    public partial class DeliveryRemovedMessagePayload : IDeliveryRemovedMessagePayload
    {
        public string Type { get; set; }

        public IDelivery Delivery { get; set; }
        public DeliveryRemovedMessagePayload()
        {
            this.Type = "DeliveryRemoved";
        }
    }
}
