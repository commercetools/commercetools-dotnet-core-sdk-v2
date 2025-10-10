using commercetools.Sdk.CheckoutApi.Models.Applications;
using commercetools.Sdk.CheckoutApi.Models.Carts;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.CheckoutApi.Models.Transactions
{
    [DeserializeAs(typeof(commercetools.Sdk.CheckoutApi.Models.Transactions.Transaction))]
    public partial interface ITransaction
    {
        string Id { get; set; }

        string Key { get; set; }

        int Version { get; set; }

        IApplicationReference Application { get; set; }

        IList<ITransactionItem> TransactionItems { get; set; }

        IEnumerable<ITransactionItem> TransactionItemsEnumerable { set => TransactionItems = value.ToList(); }

        ICartReference Cart { get; set; }

        ITransactionStatus TransactionStatus { get; set; }

        IOrderReference Order { get; set; }

        DateTime CreatedAt { get; set; }

        DateTime LastModifiedAt { get; set; }

    }
}
