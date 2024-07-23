using commercetools.Sdk.Api.Models.Orders;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.OrderShipmentStateChangedMessagePayload))]
    public partial interface IOrderShipmentStateChangedMessagePayload : IOrderMessagePayload
    {
        IShipmentState ShipmentState { get; set; }

        IShipmentState OldShipmentState { get; set; }

    }
}
