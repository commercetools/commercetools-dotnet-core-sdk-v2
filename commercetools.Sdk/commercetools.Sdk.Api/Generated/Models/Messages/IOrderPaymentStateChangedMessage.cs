using commercetools.Api.Models.Orders;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Api.Models.Messages.OrderPaymentStateChangedMessage))]
    public partial interface IOrderPaymentStateChangedMessage : IMessage
    {
        IPaymentState PaymentState { get; set;}
        
        IPaymentState OldPaymentState { get; set;}
    }
}
