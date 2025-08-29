using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.CheckoutApi.Models.Transactions
{
    [DeserializeAs(typeof(commercetools.Sdk.CheckoutApi.Models.Transactions.TransactionStatus))]
    public partial interface ITransactionStatus
    {
        ITransactionState State { get; set; }

        IList<ITransactionError> Errors { get; set; }

        IEnumerable<ITransactionError> ErrorsEnumerable { set => Errors = value.ToList(); }

    }
}
