using System.Collections.Generic;
using System.Linq;

namespace commercetools.Sdk.CheckoutApi.Models.Transactions
{

    public partial class TransactionStatus : ITransactionStatus
    {
        public ITransactionState State { get; set; }

        public IList<ITransactionError> Errors { get; set; }

        public IEnumerable<ITransactionError> ErrorsEnumerable { set => Errors = value.ToList(); }
    }
}
