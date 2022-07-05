using commercetools.Sdk.Api.Models.Carts;


namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class OrderCustomLineItemRemovedMessagePayload : IOrderCustomLineItemRemovedMessagePayload
    {
        public string Type { get; set; }

        public string CustomLineItemId { get; set; }

        public ICustomLineItem CustomLineItem { get; set; }
        public OrderCustomLineItemRemovedMessagePayload()
        {
            this.Type = "OrderCustomLineItemRemoved";
        }
    }
}
