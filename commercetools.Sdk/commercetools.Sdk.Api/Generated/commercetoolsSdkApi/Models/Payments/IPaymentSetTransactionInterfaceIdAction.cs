using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Payments
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Payments.PaymentSetTransactionInterfaceIdAction))]
    public partial interface IPaymentSetTransactionInterfaceIdAction : IPaymentUpdateAction
    {
        string TransactionId { get; set; }

        string InterfaceId { get; set; }

    }
}
