using commercetools.Sdk.CheckoutApi.Models.Common;
using commercetools.Sdk.CheckoutApi.Models.PaymentIntegrations;


namespace commercetools.Sdk.CheckoutApi.Models.Transactions
{

    public partial class TransactionItemPaymentIntegrationDraft : ITransactionItemPaymentIntegrationDraft
    {
        public string Type { get; set; }

        public IAmount Amount { get; set; }

        public IPaymentIntegrationResourceIdentifier PaymentIntegration { get; set; }
    }
}
