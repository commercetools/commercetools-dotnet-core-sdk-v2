using commercetools.Sdk.Api.Models.Orders;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.OrderPaymentStateChangedMessage))]
    public partial interface IOrderPaymentStateChangedMessage : IOrderMessage
    {
        IPaymentState PaymentState { get; set; }

        IPaymentState OldPaymentState { get; set; }
    }
}
