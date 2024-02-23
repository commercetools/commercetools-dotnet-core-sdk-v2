using commercetools.Sdk.Api.Models.Orders;


namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class OrderDeletedMessagePayload : IOrderDeletedMessagePayload
    {
        public string Type { get; set; }

        public IOrder Order { get; set; }
        public OrderDeletedMessagePayload()
        {
            this.Type = "OrderDeleted";
        }
    }
}
