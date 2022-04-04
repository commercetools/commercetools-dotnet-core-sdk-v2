using commercetools.Sdk.Api.Models.Orders;


namespace commercetools.Sdk.Api.Models.Messages
{
    public partial class OrderStateChangedMessagePayload : IOrderStateChangedMessagePayload
    {
        public string Type { get; set; }

        public IOrderState OrderState { get; set; }

        public IOrderState OldOrderState { get; set; }
        public OrderStateChangedMessagePayload()
        {
            this.Type = "OrderStateChanged";
        }
    }
}
