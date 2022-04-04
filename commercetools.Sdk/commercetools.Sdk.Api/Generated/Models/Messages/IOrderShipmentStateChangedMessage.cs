using commercetools.Sdk.Api.Models.Orders;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.OrderShipmentStateChangedMessage))]
    public partial interface IOrderShipmentStateChangedMessage : IOrderMessage
    {
        IShipmentState ShipmentState { get; set; }

        IShipmentState OldShipmentState { get; set; }
    }
}
