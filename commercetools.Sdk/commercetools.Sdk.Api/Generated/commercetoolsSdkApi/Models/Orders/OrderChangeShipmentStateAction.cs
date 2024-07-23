namespace commercetools.Sdk.Api.Models.Orders
{

    public partial class OrderChangeShipmentStateAction : IOrderChangeShipmentStateAction
    {
        public string Action { get; set; }

        public IShipmentState ShipmentState { get; set; }
        public OrderChangeShipmentStateAction()
        {
            this.Action = "changeShipmentState";
        }
    }
}
