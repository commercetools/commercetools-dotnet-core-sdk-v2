using commercetools.Sdk.Api.Models.Carts;


namespace commercetools.Sdk.Api.Models.Messages
{
    public partial class OrderCustomLineItemAddedMessagePayload : IOrderCustomLineItemAddedMessagePayload
    {
        public string Type { get; set; }

        public ICustomLineItem CustomLineItem { get; set; }
        public OrderCustomLineItemAddedMessagePayload()
        {
            this.Type = "OrderCustomLineItemAdded";
        }
    }
}
