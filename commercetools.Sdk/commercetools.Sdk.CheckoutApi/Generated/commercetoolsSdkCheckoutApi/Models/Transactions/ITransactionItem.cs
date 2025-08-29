using commercetools.Sdk.CheckoutApi.Models.Common;
using commercetools.Sdk.CheckoutApi.Models.PaymentIntegrations;
using commercetools.Sdk.CheckoutApi.Models.Payments;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.CheckoutApi.Models.Transactions
{
    [DeserializeAs(typeof(commercetools.Sdk.CheckoutApi.Models.Transactions.TransactionItem))]
    public partial interface ITransactionItem
    {
        IAmount Amount { get; set; }

        IPaymentReference Payment { get; set; }

        IPaymentIntegrationReference PaymentIntegration { get; set; }

    }
}
