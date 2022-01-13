using commercetools.Api.Models.Orders;


namespace commercetools.Api.Models.OrderEdits
{
    public partial class StagedOrderChangeShipmentStateAction : IStagedOrderChangeShipmentStateAction
    {
        public string Action { get; set; }

        public IShipmentState ShipmentState { get; set; }
        public StagedOrderChangeShipmentStateAction()
        {
            this.Action = "changeShipmentState";
        }
    }
}
