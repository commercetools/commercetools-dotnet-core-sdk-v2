using commercetools.Api.Models.Payments;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Api.Models.Messages.PaymentCreatedMessage))]
    public partial interface IPaymentCreatedMessage : IMessage
    {
        IPayment Payment { get; set;}
    }
}
