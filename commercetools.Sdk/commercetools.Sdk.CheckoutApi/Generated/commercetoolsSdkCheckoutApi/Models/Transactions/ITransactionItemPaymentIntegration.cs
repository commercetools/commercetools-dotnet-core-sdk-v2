using commercetools.Sdk.CheckoutApi.Models.PaymentIntegrations;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.CheckoutApi.Models.Transactions
{
    [DeserializeAs(typeof(commercetools.Sdk.CheckoutApi.Models.Transactions.TransactionItemPaymentIntegration))]
    public partial interface ITransactionItemPaymentIntegration : ITransactionItem
    {
        new string Type { get; set; }

        IPaymentIntegrationReference PaymentIntegration { get; set; }

    }
}
