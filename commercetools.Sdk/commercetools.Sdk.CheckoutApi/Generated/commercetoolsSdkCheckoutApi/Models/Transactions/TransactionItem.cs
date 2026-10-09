using commercetools.Sdk.CheckoutApi.Models.Common;
using commercetools.Sdk.CheckoutApi.Models.Payments;

namespace commercetools.Sdk.CheckoutApi.Models.Transactions
{

    public partial class TransactionItem : ITransactionItem
    {
        public string Type { get; set; }

        public IAmount Amount { get; set; }

        public IPaymentReference Payment { get; set; }
    }
}
