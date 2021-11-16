namespace commercetools.Api.Models.Orders
{
    public partial class OrderRemoveDeliveryAction : IOrderRemoveDeliveryAction
    {
        public string Action { get; set;}
        
        public string DeliveryId { get; set;}
        public OrderRemoveDeliveryAction()
        { 
           this.Action = "removeDelivery";
        }
    }
}
