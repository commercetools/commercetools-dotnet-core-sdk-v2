using commercetools.Sdk.CheckoutApi.Models.Applications;
using commercetools.Sdk.CheckoutApi.Models.Carts;
using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.CheckoutApi.Models.Transactions
{
    [DeserializeAs(typeof(commercetools.Sdk.CheckoutApi.Models.Transactions.TransactionDraft))]
    public partial interface ITransactionDraft
    {
        string Key { get; set; }

        IApplicationResourceIdentifier Application { get; set; }

        IList<ITransactionItemDraft> TransactionItems { get; set; }

        IEnumerable<ITransactionItemDraft> TransactionItemsEnumerable { set => TransactionItems = value.ToList(); }

        ICartResourceIdentifier Cart { get; set; }

    }
}
