using commercetools.Sdk.Api.Models.Carts;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.OrderEstimatedDeliverySetMessagePayload))]
    public partial interface IOrderEstimatedDeliverySetMessagePayload : IOrderMessagePayload
    {
        IEstimatedDelivery EstimatedDelivery { get; set; }

        string ShippingKey { get; set; }

    }
}
