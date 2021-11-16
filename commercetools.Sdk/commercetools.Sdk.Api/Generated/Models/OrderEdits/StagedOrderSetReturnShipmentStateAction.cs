using commercetools.Api.Models.Orders;


namespace commercetools.Api.Models.OrderEdits
{
    public partial class StagedOrderSetReturnShipmentStateAction : IStagedOrderSetReturnShipmentStateAction
    {
        public string Action { get; set;}
        
        public string ReturnItemId { get; set;}
        
        public IReturnShipmentState ShipmentState { get; set;}
        public StagedOrderSetReturnShipmentStateAction()
        { 
           this.Action = "setReturnShipmentState";
        }
    }
}
