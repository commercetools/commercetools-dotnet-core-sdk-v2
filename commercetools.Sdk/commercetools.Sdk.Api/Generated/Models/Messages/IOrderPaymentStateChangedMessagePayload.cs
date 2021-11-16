using commercetools.Api.Models.Orders;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Api.Models.Messages.OrderPaymentStateChangedMessagePayload))]
    public partial interface IOrderPaymentStateChangedMessagePayload : IMessagePayload
    {
        IPaymentState PaymentState { get; set;}
        
        IPaymentState OldPaymentState { get; set;}
    }
}
