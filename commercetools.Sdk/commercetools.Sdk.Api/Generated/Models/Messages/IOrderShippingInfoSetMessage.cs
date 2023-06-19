using commercetools.Sdk.Api.Models.Carts;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.OrderShippingInfoSetMessage))]
    public partial interface IOrderShippingInfoSetMessage : IOrderMessage
    {
        IShippingInfo ShippingInfo { get; set; }

        IShippingInfo OldShippingInfo { get; set; }

    }
}
