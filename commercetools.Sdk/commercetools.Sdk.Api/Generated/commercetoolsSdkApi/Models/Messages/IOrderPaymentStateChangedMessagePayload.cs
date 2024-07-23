using commercetools.Sdk.Api.Models.Orders;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.OrderPaymentStateChangedMessagePayload))]
    public partial interface IOrderPaymentStateChangedMessagePayload : IOrderMessagePayload
    {
        IPaymentState PaymentState { get; set; }

        IPaymentState OldPaymentState { get; set; }

    }
}
