using commercetools.Sdk.Api.Models.Carts;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Orders
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Orders.OrderSetEstimatedDeliveryAction))]
    public partial interface IOrderSetEstimatedDeliveryAction : IOrderUpdateAction
    {
        string ShippingKey { get; set; }

        IEstimatedDelivery EstimatedDelivery { get; set; }

    }
}
