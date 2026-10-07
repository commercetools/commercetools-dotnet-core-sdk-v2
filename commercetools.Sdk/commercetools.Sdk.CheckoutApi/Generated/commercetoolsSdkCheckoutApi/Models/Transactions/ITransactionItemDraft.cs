using commercetools.Sdk.CheckoutApi.Models.Common;
using commercetools.Base.CustomAttributes;
using System;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.CheckoutApi.Models.Transactions
{
    [TypeDiscriminator(nameof(Type))]
    [DefaultTypeDiscriminator(typeof(commercetools.Sdk.CheckoutApi.Models.Transactions.TransactionItemDraft))]
    [SubTypeDiscriminator("Recurring", typeof(commercetools.Sdk.CheckoutApi.Models.Transactions.TransactionItemRecurringDraft))]
    public partial interface ITransactionItemDraft
    {
        string Type { get; set; }

        IAmount Amount { get; set; }

        static commercetools.Sdk.CheckoutApi.Models.Transactions.TransactionItemRecurringDraft Recurring(Action<commercetools.Sdk.CheckoutApi.Models.Transactions.TransactionItemRecurringDraft> init = null)
        {
            var t = new commercetools.Sdk.CheckoutApi.Models.Transactions.TransactionItemRecurringDraft();
            init?.Invoke(t);
            return t;
        }
    }
}
