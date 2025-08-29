using commercetools.Sdk.CheckoutApi.Models.Common;
using commercetools.Sdk.CheckoutApi.Models.PaymentIntegrations;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.CheckoutApi.Models.Transactions
{
    [DeserializeAs(typeof(commercetools.Sdk.CheckoutApi.Models.Transactions.TransactionItemDraft))]
    public partial interface ITransactionItemDraft
    {
        IPaymentIntegrationResourceIdentifier PaymentIntegration { get; set; }

        IAmount Amount { get; set; }

    }
}
