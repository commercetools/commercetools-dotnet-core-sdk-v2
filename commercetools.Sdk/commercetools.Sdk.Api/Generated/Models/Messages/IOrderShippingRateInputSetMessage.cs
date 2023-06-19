using commercetools.Sdk.Api.Models.Carts;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.OrderShippingRateInputSetMessage))]
    public partial interface IOrderShippingRateInputSetMessage : IOrderMessage
    {
        IShippingRateInput ShippingRateInput { get; set; }

        IShippingRateInput OldShippingRateInput { get; set; }

    }
}
