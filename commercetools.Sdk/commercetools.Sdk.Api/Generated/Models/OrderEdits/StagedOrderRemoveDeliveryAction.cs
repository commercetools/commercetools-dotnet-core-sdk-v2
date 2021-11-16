namespace commercetools.Api.Models.OrderEdits
{
    public partial class StagedOrderRemoveDeliveryAction : IStagedOrderRemoveDeliveryAction
    {
        public string Action { get; set;}
        
        public string DeliveryId { get; set;}
        public StagedOrderRemoveDeliveryAction()
        { 
           this.Action = "removeDelivery";
        }
    }
}
