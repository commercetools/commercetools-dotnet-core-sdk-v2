using commercetools.Sdk.CheckoutApi.Models.Common;
using commercetools.Sdk.CheckoutApi.Models.PaymentIntegrations;


namespace commercetools.Sdk.CheckoutApi.Models.Transactions
{

    public partial class TransactionItemDraft : ITransactionItemDraft
    {
        public IPaymentIntegrationResourceIdentifier PaymentIntegration { get; set; }

        public IAmount Amount { get; set; }
    }
}
