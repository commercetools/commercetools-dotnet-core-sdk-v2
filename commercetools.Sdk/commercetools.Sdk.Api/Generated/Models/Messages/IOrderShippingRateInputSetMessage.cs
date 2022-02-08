using commercetools.Api.Models.Carts;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Api.Models.Messages.OrderShippingRateInputSetMessage))]
    public partial interface IOrderShippingRateInputSetMessage : IOrderMessage
    {
        IShippingRateInput ShippingRateInput { get; set; }

        IShippingRateInput OldShippingRateInput { get; set; }
    }
}
