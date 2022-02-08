using commercetools.Api.Models.Orders;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Api.Models.Messages.OrderPaymentStateChangedMessage))]
    public partial interface IOrderPaymentStateChangedMessage : IOrderMessage
    {
        IPaymentState PaymentState { get; set; }

        IPaymentState OldPaymentState { get; set; }
    }
}
