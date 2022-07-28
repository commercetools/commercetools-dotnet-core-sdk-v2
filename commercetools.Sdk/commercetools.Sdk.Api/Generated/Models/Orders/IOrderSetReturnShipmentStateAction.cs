using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Orders
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Orders.OrderSetReturnShipmentStateAction))]
    public partial interface IOrderSetReturnShipmentStateAction : IOrderUpdateAction
    {
        string ReturnItemId { get; set; }

        IReturnShipmentState ShipmentState { get; set; }

    }
}
