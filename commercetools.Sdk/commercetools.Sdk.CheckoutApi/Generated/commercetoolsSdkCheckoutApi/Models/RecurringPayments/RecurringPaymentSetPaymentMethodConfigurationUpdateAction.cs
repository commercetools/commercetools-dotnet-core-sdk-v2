using System.Collections.Generic;
using System.Linq;

namespace commercetools.Sdk.CheckoutApi.Models.RecurringPayments
{

    public partial class RecurringPaymentSetPaymentMethodConfigurationUpdateAction : IRecurringPaymentSetPaymentMethodConfigurationUpdateAction
    {
        public string Action { get; set; }

        public IList<IPaymentMethodConfiguration> PaymentMethodConfigurations { get; set; }

        public IEnumerable<IPaymentMethodConfiguration> PaymentMethodConfigurationsEnumerable { set => PaymentMethodConfigurations = value.ToList(); }
        public RecurringPaymentSetPaymentMethodConfigurationUpdateAction()
        {
            this.Action = "setPaymentMethodConfiguration";
        }
    }
}
