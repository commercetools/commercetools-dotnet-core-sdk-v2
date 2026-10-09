using commercetools.Sdk.CheckoutApi.Models.Common;
using commercetools.Sdk.CheckoutApi.Models.PaymentIntegrations;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.CheckoutApi.Models.Transactions
{
    [DeserializeAs(typeof(commercetools.Sdk.CheckoutApi.Models.Transactions.TransactionItemRecurringDraft))]
    public partial interface ITransactionItemRecurringDraft : ITransactionItemDraft
    {
        IPaymentMethodReference PaymentMethod { get; set; }

        IConnectorDeploymentReference ConnectorDeployment { get; set; }

    }
}
