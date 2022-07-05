using commercetools.Sdk.Api.Models.Orders;


namespace commercetools.Sdk.Api.Models.Messages
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
