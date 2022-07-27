using commercetools.Sdk.Api.Models.Orders;


namespace commercetools.Sdk.Api.Models.OrderEdits
{

    public partial class StagedOrderSetReturnShipmentStateAction : IStagedOrderSetReturnShipmentStateAction
    {
        public string Action { get; set; }

        public string ReturnItemId { get; set; }

        public IReturnShipmentState ShipmentState { get; set; }
        public StagedOrderSetReturnShipmentStateAction()
        {
            this.Action = "setReturnShipmentState";
        }
    }
}
