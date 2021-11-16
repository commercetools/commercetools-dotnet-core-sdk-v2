namespace commercetools.Api.Models.OrderEdits
{
    public partial class StagedOrderRemoveParcelFromDeliveryAction : IStagedOrderRemoveParcelFromDeliveryAction
    {
        public string Action { get; set;}
        
        public string ParcelId { get; set;}
        public StagedOrderRemoveParcelFromDeliveryAction()
        { 
           this.Action = "removeParcelFromDelivery";
        }
    }
}
