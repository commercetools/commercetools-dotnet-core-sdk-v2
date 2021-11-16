using commercetools.Api.Models.Payments;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Api.Models.Messages.PaymentTransactionAddedMessagePayload))]
    public partial interface IPaymentTransactionAddedMessagePayload : IMessagePayload
    {
        ITransaction Transaction { get; set; }
    }
}
