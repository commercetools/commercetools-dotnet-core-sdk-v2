using commercetools.Api.Models.Orders;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Api.Models.Messages.OrderShipmentStateChangedMessage))]
    public partial interface IOrderShipmentStateChangedMessage : IMessage
    {
        IShipmentState ShipmentState { get; set; }

        IShipmentState OldShipmentState { get; set; }
    }
}
