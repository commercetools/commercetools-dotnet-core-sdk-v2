using commercetools.Sdk.Api.Models.Carts;


namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class CartEstimatedDeliverySetMessagePayload : ICartEstimatedDeliverySetMessagePayload
    {
        public string Type { get; set; }

        public IEstimatedDelivery EstimatedDelivery { get; set; }

        public string ShippingKey { get; set; }
        public CartEstimatedDeliverySetMessagePayload()
        {
            this.Type = "CartEstimatedDeliverySet";
        }
    }
}
