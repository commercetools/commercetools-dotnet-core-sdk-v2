using commercetools.Base.CustomAttributes;
using System;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.CheckoutApi.Models.RecurringPayments
{
    [TypeDiscriminator(nameof(Action))]
    [DefaultTypeDiscriminator(typeof(commercetools.Sdk.CheckoutApi.Models.RecurringPayments.RecurringPaymentUpdateAction))]
    [SubTypeDiscriminator("addPaymentMethodConfiguration", typeof(commercetools.Sdk.CheckoutApi.Models.RecurringPayments.RecurringPaymentAddPaymentMethodConfigurationUpdateAction))]
    [SubTypeDiscriminator("setKey", typeof(commercetools.Sdk.CheckoutApi.Models.RecurringPayments.RecurringPaymentSetKeyUpdateAction))]
    [SubTypeDiscriminator("setPaymentMethodConfiguration", typeof(commercetools.Sdk.CheckoutApi.Models.RecurringPayments.RecurringPaymentSetPaymentMethodConfigurationUpdateAction))]
    [SubTypeDiscriminator("setRecurringOrder", typeof(commercetools.Sdk.CheckoutApi.Models.RecurringPayments.RecurringPaymentSetRecurringOrderUpdateAction))]
    public partial interface IRecurringPaymentUpdateAction
    {
        string Action { get; set; }

        static commercetools.Sdk.CheckoutApi.Models.RecurringPayments.RecurringPaymentAddPaymentMethodConfigurationUpdateAction AddPaymentMethodConfiguration(Action<commercetools.Sdk.CheckoutApi.Models.RecurringPayments.RecurringPaymentAddPaymentMethodConfigurationUpdateAction> init = null)
        {
            var t = new commercetools.Sdk.CheckoutApi.Models.RecurringPayments.RecurringPaymentAddPaymentMethodConfigurationUpdateAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.CheckoutApi.Models.RecurringPayments.RecurringPaymentSetKeyUpdateAction SetKey(Action<commercetools.Sdk.CheckoutApi.Models.RecurringPayments.RecurringPaymentSetKeyUpdateAction> init = null)
        {
            var t = new commercetools.Sdk.CheckoutApi.Models.RecurringPayments.RecurringPaymentSetKeyUpdateAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.CheckoutApi.Models.RecurringPayments.RecurringPaymentSetPaymentMethodConfigurationUpdateAction SetPaymentMethodConfiguration(Action<commercetools.Sdk.CheckoutApi.Models.RecurringPayments.RecurringPaymentSetPaymentMethodConfigurationUpdateAction> init = null)
        {
            var t = new commercetools.Sdk.CheckoutApi.Models.RecurringPayments.RecurringPaymentSetPaymentMethodConfigurationUpdateAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.CheckoutApi.Models.RecurringPayments.RecurringPaymentSetRecurringOrderUpdateAction SetRecurringOrder(Action<commercetools.Sdk.CheckoutApi.Models.RecurringPayments.RecurringPaymentSetRecurringOrderUpdateAction> init = null)
        {
            var t = new commercetools.Sdk.CheckoutApi.Models.RecurringPayments.RecurringPaymentSetRecurringOrderUpdateAction();
            init?.Invoke(t);
            return t;
        }
    }
}
