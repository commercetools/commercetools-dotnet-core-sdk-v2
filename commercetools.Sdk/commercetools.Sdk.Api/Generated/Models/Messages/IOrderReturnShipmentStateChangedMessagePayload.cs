using commercetools.Api.Models.Orders;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Api.Models.Messages.OrderReturnShipmentStateChangedMessagePayload))]
    public partial interface IOrderReturnShipmentStateChangedMessagePayload : IMessagePayload
    {
        string ReturnItemId { get; set; }

        IReturnShipmentState ReturnShipmentState { get; set; }
    }
}
