using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Orders
{
    [DeserializeAs(typeof(commercetools.Api.Models.Orders.OrderChangeShipmentStateAction))]
    public partial interface IOrderChangeShipmentStateAction : IOrderUpdateAction
    {
        IShipmentState ShipmentState { get; set;}
    }
}
