using commercetools.Sdk.Api.Models.Orders;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.OrderStateChangedMessage))]
    public partial interface IOrderStateChangedMessage : IOrderMessage
    {
        IOrderState OrderState { get; set; }

        IOrderState OldOrderState { get; set; }

    }
}
