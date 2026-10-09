using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.CheckoutApi.Models.RecurringPayments
{
    [DeserializeAs(typeof(commercetools.Sdk.CheckoutApi.Models.RecurringPayments.RecurringPaymentAddPaymentMethodConfigurationUpdateAction))]
    public partial interface IRecurringPaymentAddPaymentMethodConfigurationUpdateAction : IRecurringPaymentUpdateAction
    {
        IPaymentMethodConfiguration PaymentMethodConfiguration { get; set; }

    }
}
