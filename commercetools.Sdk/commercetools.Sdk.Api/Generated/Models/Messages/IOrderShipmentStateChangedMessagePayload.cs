using commercetools.Api.Models.Orders;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Api.Models.Messages.OrderShipmentStateChangedMessagePayload))]
    public partial interface IOrderShipmentStateChangedMessagePayload : IOrderMessagePayload
    {
        IShipmentState ShipmentState { get; set; }

        IShipmentState OldShipmentState { get; set; }
    }
}
