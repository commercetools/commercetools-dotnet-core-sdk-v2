using commercetools.Api.Models.Orders;


namespace commercetools.Api.Models.Messages
{
    public partial class OrderImportedMessagePayload : IOrderImportedMessagePayload
    {
        public string Type { get; set; }

        public IOrder Order { get; set; }
        public OrderImportedMessagePayload()
        {
            this.Type = "OrderImported";
        }
    }
}
