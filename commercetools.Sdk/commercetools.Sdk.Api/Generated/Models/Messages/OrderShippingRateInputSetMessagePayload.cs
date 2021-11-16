using commercetools.Api.Models.Carts;


namespace commercetools.Api.Models.Messages
{
    public partial class OrderShippingRateInputSetMessagePayload : IOrderShippingRateInputSetMessagePayload
    {
        public string Type { get; set;}
        
        public IShippingRateInput ShippingRateInput { get; set;}
        
        public IShippingRateInput OldShippingRateInput { get; set;}
        public OrderShippingRateInputSetMessagePayload()
        { 
           this.Type = "OrderShippingRateInputSet";
        }
    }
}
