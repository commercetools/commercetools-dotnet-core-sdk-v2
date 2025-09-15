

namespace commercetools.Sdk.CheckoutApi.Models.Transactions
{

    public partial class TransactionError : ITransactionError
    {
        public string Code { get; set; }

        public string Message { get; set; }
    }
}
