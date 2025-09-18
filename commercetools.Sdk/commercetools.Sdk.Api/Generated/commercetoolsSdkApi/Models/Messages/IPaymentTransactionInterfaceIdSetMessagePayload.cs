using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.PaymentTransactionInterfaceIdSetMessagePayload))]
    public partial interface IPaymentTransactionInterfaceIdSetMessagePayload : IMessagePayload
    {
        string TransactionId { get; set; }

        string NewInterfaceId { get; set; }

        string OldInterfaceId { get; set; }

    }
}
