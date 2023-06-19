using commercetools.Sdk.Api.Models.Carts;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.OrderShippingRateInputSetMessagePayload))]
    public partial interface IOrderShippingRateInputSetMessagePayload : IOrderMessagePayload
    {
        IShippingRateInput ShippingRateInput { get; set; }

        IShippingRateInput OldShippingRateInput { get; set; }

    }
}
