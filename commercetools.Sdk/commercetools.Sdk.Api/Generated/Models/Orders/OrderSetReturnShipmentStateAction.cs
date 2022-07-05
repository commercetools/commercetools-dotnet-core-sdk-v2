namespace commercetools.Sdk.Api.Models.Orders
{

    public partial class OrderSetReturnShipmentStateAction : IOrderSetReturnShipmentStateAction
    {
        public string Action { get; set; }

        public string ReturnItemId { get; set; }

        public IReturnShipmentState ShipmentState { get; set; }
        public OrderSetReturnShipmentStateAction()
        {
            this.Action = "setReturnShipmentState";
        }
    }
}
