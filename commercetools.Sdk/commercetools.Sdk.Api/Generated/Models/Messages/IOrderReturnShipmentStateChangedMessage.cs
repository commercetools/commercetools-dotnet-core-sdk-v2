using commercetools.Api.Models.Orders;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Api.Models.Messages.OrderReturnShipmentStateChangedMessage))]
    public partial interface IOrderReturnShipmentStateChangedMessage : IOrderMessage
    {
        string ReturnItemId { get; set; }

        IReturnShipmentState ReturnShipmentState { get; set; }
    }
}
