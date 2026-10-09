using commercetools.Sdk.CheckoutApi.Models.Common;
using commercetools.Sdk.CheckoutApi.Models.Payments;
using commercetools.Base.CustomAttributes;
using System;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.CheckoutApi.Models.Transactions
{
    [TypeDiscriminator(nameof(Type))]
    [DefaultTypeDiscriminator(typeof(commercetools.Sdk.CheckoutApi.Models.Transactions.TransactionItem))]
    [SubTypeDiscriminator("Recurring", typeof(commercetools.Sdk.CheckoutApi.Models.Transactions.TransactionItemRecurring))]
    public partial interface ITransactionItem
    {
        string Type { get; set; }

        IAmount Amount { get; set; }

        IPaymentReference Payment { get; set; }

        static commercetools.Sdk.CheckoutApi.Models.Transactions.TransactionItemRecurring Recurring(Action<commercetools.Sdk.CheckoutApi.Models.Transactions.TransactionItemRecurring> init = null)
        {
            var t = new commercetools.Sdk.CheckoutApi.Models.Transactions.TransactionItemRecurring();
            init?.Invoke(t);
            return t;
        }
    }
}
