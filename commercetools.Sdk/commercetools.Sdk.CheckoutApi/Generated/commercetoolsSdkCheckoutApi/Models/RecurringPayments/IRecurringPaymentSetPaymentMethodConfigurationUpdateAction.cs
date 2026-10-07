using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.CheckoutApi.Models.RecurringPayments
{
    [DeserializeAs(typeof(commercetools.Sdk.CheckoutApi.Models.RecurringPayments.RecurringPaymentSetPaymentMethodConfigurationUpdateAction))]
    public partial interface IRecurringPaymentSetPaymentMethodConfigurationUpdateAction : IRecurringPaymentUpdateAction
    {
        IList<IPaymentMethodConfiguration> PaymentMethodConfigurations { get; set; }

        IEnumerable<IPaymentMethodConfiguration> PaymentMethodConfigurationsEnumerable { set => PaymentMethodConfigurations = value.ToList(); }

    }
}
