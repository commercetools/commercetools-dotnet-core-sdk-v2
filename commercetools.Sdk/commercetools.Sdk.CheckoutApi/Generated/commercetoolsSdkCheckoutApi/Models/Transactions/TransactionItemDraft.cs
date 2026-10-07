using commercetools.Sdk.CheckoutApi.Models.Common;

namespace commercetools.Sdk.CheckoutApi.Models.Transactions
{

    public partial class TransactionItemDraft : ITransactionItemDraft
    {
        public string Type { get; set; }

        public IAmount Amount { get; set; }
    }
}
