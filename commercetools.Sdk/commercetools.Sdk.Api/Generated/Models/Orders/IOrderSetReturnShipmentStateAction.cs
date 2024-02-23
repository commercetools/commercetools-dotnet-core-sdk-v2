using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Orders
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Orders.OrderSetReturnShipmentStateAction))]
    public partial interface IOrderSetReturnShipmentStateAction : IOrderUpdateAction
    {
        string ReturnItemId { get; set; }

        string ReturnItemKey { get; set; }

        IReturnShipmentState ShipmentState { get; set; }

    }
}
