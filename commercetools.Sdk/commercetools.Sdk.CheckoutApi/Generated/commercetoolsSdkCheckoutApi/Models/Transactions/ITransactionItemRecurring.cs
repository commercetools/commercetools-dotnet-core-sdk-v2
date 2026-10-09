using commercetools.Sdk.CheckoutApi.Models.Common;
using commercetools.Sdk.CheckoutApi.Models.PaymentIntegrations;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.CheckoutApi.Models.Transactions
{
    [DeserializeAs(typeof(commercetools.Sdk.CheckoutApi.Models.Transactions.TransactionItemRecurring))]
    public partial interface ITransactionItemRecurring : ITransactionItem
    {
        IPaymentMethodReference PaymentMethod { get; set; }

        IConnectorDeploymentReference ConnectorDeployment { get; set; }

    }
}
