using commercetools.Sdk.CheckoutApi.Models.Applications;
using commercetools.Sdk.CheckoutApi.Models.Carts;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Sdk.CheckoutApi.Models.Transactions
{

    public partial class Transaction : ITransaction
    {
        public string Id { get; set; }

        public string Key { get; set; }

        public int Version { get; set; }

        public IApplicationReference Application { get; set; }

        public IList<ITransactionItem> TransactionItems { get; set; }

        public IEnumerable<ITransactionItem> TransactionItemsEnumerable { set => TransactionItems = value.ToList(); }

        public ICartReference Cart { get; set; }

        public ITransactionStatus TransactionStatus { get; set; }

        public IOrderReference Order { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime LastModifiedAt { get; set; }
    }
}
