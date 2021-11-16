using commercetools.Api.Models.Payments;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Api.Models.Messages.PaymentCreatedMessagePayload))]
    public partial interface IPaymentCreatedMessagePayload : IMessagePayload
    {
        IPayment Payment { get; set;}
    }
}
