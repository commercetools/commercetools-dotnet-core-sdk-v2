using commercetools.Sdk.Api.Models.Carts;


namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class OrderLineItemAddedMessagePayload : IOrderLineItemAddedMessagePayload
    {
        public string Type { get; set; }

        public ILineItem LineItem { get; set; }

        public long AddedQuantity { get; set; }
        public OrderLineItemAddedMessagePayload()
        {
            this.Type = "OrderLineItemAdded";
        }
    }
}
