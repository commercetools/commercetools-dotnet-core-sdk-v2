using commercetools.Api.Models.Orders;


namespace commercetools.Api.Models.Messages
{
    public partial class OrderShipmentStateChangedMessagePayload : IOrderShipmentStateChangedMessagePayload
    {
        public string Type { get; set;}
        
        public IShipmentState ShipmentState { get; set;}
        
        public IShipmentState OldShipmentState { get; set;}
        public OrderShipmentStateChangedMessagePayload()
        { 
           this.Type = "OrderShipmentStateChanged";
        }
    }
}
