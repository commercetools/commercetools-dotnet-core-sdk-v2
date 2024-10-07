using commercetools.Sdk.Api.Models.Orders;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.OrderReturnShipmentStateChangedMessagePayload))]
    public partial interface IOrderReturnShipmentStateChangedMessagePayload : IOrderMessagePayload
    {
        string ReturnItemId { get; set; }

        IReturnShipmentState ReturnShipmentState { get; set; }

    }
}
