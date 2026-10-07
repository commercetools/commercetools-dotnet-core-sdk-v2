using commercetools.Sdk.CheckoutApi.Models.Common;
using commercetools.Sdk.CheckoutApi.Models.PaymentIntegrations;
using commercetools.Sdk.CheckoutApi.Models.Payments;


namespace commercetools.Sdk.CheckoutApi.Models.Transactions
{

    public partial class TransactionItemRecurring : ITransactionItemRecurring
    {
        public string Type { get; set; }

        public IAmount Amount { get; set; }

        public IPaymentReference Payment { get; set; }

        public IPaymentMethodReference PaymentMethod { get; set; }

        public IConnectorDeploymentReference ConnectorDeployment { get; set; }
        public TransactionItemRecurring()
        {
            this.Type = "Recurring";
        }
    }
}
