using commercetools.Sdk.Api.Models.Payments;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.PaymentTransactionStateChangedMessage))]
    public partial interface IPaymentTransactionStateChangedMessage : IMessage
    {
        string TransactionId { get; set; }

        ITransactionState State { get; set; }

    }
}
