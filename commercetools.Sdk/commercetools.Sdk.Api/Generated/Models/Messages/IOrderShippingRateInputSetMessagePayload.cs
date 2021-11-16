using commercetools.Api.Models.Carts;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Api.Models.Messages.OrderShippingRateInputSetMessagePayload))]
    public partial interface IOrderShippingRateInputSetMessagePayload : IMessagePayload
    {
        IShippingRateInput ShippingRateInput { get; set;}
        
        IShippingRateInput OldShippingRateInput { get; set;}
    }
}
