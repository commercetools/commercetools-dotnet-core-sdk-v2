using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.PaymentTransactionInterfaceIdSetMessage))]
    public partial interface IPaymentTransactionInterfaceIdSetMessage : IMessage
    {
        string TransactionId { get; set; }

        string NewInterfaceId { get; set; }

        string OldInterfaceId { get; set; }

    }
}
