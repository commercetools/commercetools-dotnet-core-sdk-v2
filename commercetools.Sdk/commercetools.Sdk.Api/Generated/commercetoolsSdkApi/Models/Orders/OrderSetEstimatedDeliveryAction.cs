using commercetools.Sdk.Api.Models.Carts;


namespace commercetools.Sdk.Api.Models.Orders
{

    public partial class OrderSetEstimatedDeliveryAction : IOrderSetEstimatedDeliveryAction
    {
        public string Action { get; set; }

        public string ShippingKey { get; set; }

        public IEstimatedDelivery EstimatedDelivery { get; set; }
        public OrderSetEstimatedDeliveryAction()
        {
            this.Action = "setEstimatedDelivery";
        }
    }
}
