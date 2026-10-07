using commercetools.Sdk.CheckoutApi.Models.Common;
using commercetools.Sdk.CheckoutApi.Models.PaymentIntegrations;


namespace commercetools.Sdk.CheckoutApi.Models.Transactions
{

    public partial class TransactionItemRecurringDraft : ITransactionItemRecurringDraft
    {
        public string Type { get; set; }

        public IAmount Amount { get; set; }

        public IPaymentMethodReference PaymentMethod { get; set; }

        public IConnectorDeploymentReference ConnectorDeployment { get; set; }
        public TransactionItemRecurringDraft()
        {
            this.Type = "Recurring";
        }
    }
}
