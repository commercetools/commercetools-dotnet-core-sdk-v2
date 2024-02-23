using commercetools.Sdk.Api.Models.Carts;


namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class OrderShippingInfoSetMessagePayload : IOrderShippingInfoSetMessagePayload
    {
        public string Type { get; set; }

        public IShippingInfo ShippingInfo { get; set; }

        public IShippingInfo OldShippingInfo { get; set; }
        public OrderShippingInfoSetMessagePayload()
        {
            this.Type = "OrderShippingInfoSet";
        }
    }
}
