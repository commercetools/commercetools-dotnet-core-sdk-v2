using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.CheckoutApi.Models.Transactions
{
    [DeserializeAs(typeof(commercetools.Sdk.CheckoutApi.Models.Transactions.TransactionError))]
    public partial interface ITransactionError
    {
        string Code { get; set; }

        string Message { get; set; }

    }
}
