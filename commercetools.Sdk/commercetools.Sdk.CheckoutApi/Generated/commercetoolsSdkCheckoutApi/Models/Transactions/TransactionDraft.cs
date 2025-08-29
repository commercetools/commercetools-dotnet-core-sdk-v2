using commercetools.Sdk.CheckoutApi.Models.Applications;
using commercetools.Sdk.CheckoutApi.Models.Carts;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Sdk.CheckoutApi.Models.Transactions
{

    public partial class TransactionDraft : ITransactionDraft
    {
        public string Key { get; set; }

        public IApplicationResourceIdentifier Application { get; set; }

        public IList<ITransactionItemDraft> TransactionItems { get; set; }

        public IEnumerable<ITransactionItemDraft> TransactionItemsEnumerable { set => TransactionItems = value.ToList(); }

        public ICartResourceIdentifier Cart { get; set; }
    }
}
