using commercetools.Sdk.CheckoutApi.Models.Common;
using commercetools.Sdk.CheckoutApi.Models.PaymentIntegrations;
using commercetools.Sdk.CheckoutApi.Models.Payments;


namespace commercetools.Sdk.CheckoutApi.Models.Transactions
{

    public partial class TransactionItemPaymentIntegration : ITransactionItemPaymentIntegration
    {
        public string Type { get; set; }

        public IAmount Amount { get; set; }

        public IPaymentReference Payment { get; set; }

        public IPaymentIntegrationReference PaymentIntegration { get; set; }
    }
}
