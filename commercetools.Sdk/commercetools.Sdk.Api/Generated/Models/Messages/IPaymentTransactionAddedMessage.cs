using commercetools.Api.Models.Payments;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Api.Models.Messages.PaymentTransactionAddedMessage))]
    public partial interface IPaymentTransactionAddedMessage : IMessage
    {
        ITransaction Transaction { get; set; }
    }
}
