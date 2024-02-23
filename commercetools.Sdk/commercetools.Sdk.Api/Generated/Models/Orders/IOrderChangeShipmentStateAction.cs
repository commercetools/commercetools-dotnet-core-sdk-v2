using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Orders
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Orders.OrderChangeShipmentStateAction))]
    public partial interface IOrderChangeShipmentStateAction : IOrderUpdateAction
    {
        IShipmentState ShipmentState { get; set; }

    }
}
