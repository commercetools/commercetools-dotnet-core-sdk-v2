using commercetools.Api.Models.Orders;


namespace commercetools.Api.Models.Messages
{
    public partial class OrderCreatedMessagePayload : IOrderCreatedMessagePayload
    {
        public string Type { get; set;}
        
        public IOrder Order { get; set;}
        public OrderCreatedMessagePayload()
        { 
           this.Type = "OrderCreated";
        }
    }
}
