namespace commercetools.Sdk.Api.Models.OrderEdits
{

    public partial class StagedOrderRemoveDeliveryAction : IStagedOrderRemoveDeliveryAction
    {
        public string Action { get; set; }

        public string DeliveryId { get; set; }

        public string DeliveryKey { get; set; }
        public StagedOrderRemoveDeliveryAction()
        {
            this.Action = "removeDelivery";
        }
    }
}
