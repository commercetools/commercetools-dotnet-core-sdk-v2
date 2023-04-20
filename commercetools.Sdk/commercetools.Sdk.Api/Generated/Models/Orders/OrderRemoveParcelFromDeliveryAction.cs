namespace commercetools.Sdk.Api.Models.Orders
{

    public partial class OrderRemoveParcelFromDeliveryAction : IOrderRemoveParcelFromDeliveryAction
    {
        public string Action { get; set; }

        public string ParcelId { get; set; }
        public OrderRemoveParcelFromDeliveryAction()
        {
            this.Action = "removeParcelFromDelivery";
        }
    }
}
