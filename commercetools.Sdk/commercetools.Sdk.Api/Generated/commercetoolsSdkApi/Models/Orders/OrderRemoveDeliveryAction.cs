

namespace commercetools.Sdk.Api.Models.Orders
{

    public partial class OrderRemoveDeliveryAction : IOrderRemoveDeliveryAction
    {
        public string Action { get; set; }

        public string DeliveryId { get; set; }

        public string DeliveryKey { get; set; }
        public OrderRemoveDeliveryAction()
        {
            this.Action = "removeDelivery";
        }
    }
}
