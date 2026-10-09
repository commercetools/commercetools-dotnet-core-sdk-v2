using commercetools.Sdk.CheckoutApi.Models.PaymentIntegrations;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.CheckoutApi.Models.Transactions
{
    [DeserializeAs(typeof(commercetools.Sdk.CheckoutApi.Models.Transactions.TransactionItemPaymentIntegrationDraft))]
    public partial interface ITransactionItemPaymentIntegrationDraft : ITransactionItemDraft
    {
        new string Type { get; set; }

        IPaymentIntegrationResourceIdentifier PaymentIntegration { get; set; }

    }
}
