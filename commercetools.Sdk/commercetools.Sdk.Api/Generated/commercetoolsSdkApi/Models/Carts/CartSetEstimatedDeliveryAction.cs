

namespace commercetools.Sdk.Api.Models.Carts
{

    public partial class CartSetEstimatedDeliveryAction : ICartSetEstimatedDeliveryAction
    {
        public string Action { get; set; }

        public string ShippingKey { get; set; }

        public IEstimatedDelivery EstimatedDelivery { get; set; }
        public CartSetEstimatedDeliveryAction()
        {
            this.Action = "setEstimatedDelivery";
        }
    }
}
