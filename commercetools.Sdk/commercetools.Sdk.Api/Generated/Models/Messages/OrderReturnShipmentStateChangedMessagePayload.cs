using commercetools.Api.Models.Orders;


namespace commercetools.Api.Models.Messages
{
    public partial class OrderReturnShipmentStateChangedMessagePayload : IOrderReturnShipmentStateChangedMessagePayload
    {
        public string Type { get; set;}
        
        public string ReturnItemId { get; set;}
        
        public IReturnShipmentState ReturnShipmentState { get; set;}
        public OrderReturnShipmentStateChangedMessagePayload()
        { 
           this.Type = "OrderReturnShipmentStateChanged";
        }
    }
}
