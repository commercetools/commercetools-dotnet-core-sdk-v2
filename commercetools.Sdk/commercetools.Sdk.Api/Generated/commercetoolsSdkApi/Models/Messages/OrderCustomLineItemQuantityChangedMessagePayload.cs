namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class OrderCustomLineItemQuantityChangedMessagePayload : IOrderCustomLineItemQuantityChangedMessagePayload
    {
        public string Type { get; set; }

        public string CustomLineItemId { get; set; }

        public string CustomLineItemKey { get; set; }

        public long Quantity { get; set; }

        public long OldQuantity { get; set; }
        public OrderCustomLineItemQuantityChangedMessagePayload()
        {
            this.Type = "OrderCustomLineItemQuantityChanged";
        }
    }
}
