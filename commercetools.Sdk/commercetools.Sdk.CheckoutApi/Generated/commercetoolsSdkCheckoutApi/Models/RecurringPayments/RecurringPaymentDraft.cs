using System.Collections.Generic;
using System.Linq;

namespace commercetools.Sdk.CheckoutApi.Models.RecurringPayments
{

    public partial class RecurringPaymentDraft : IRecurringPaymentDraft
    {
        public string Key { get; set; }

        public IRecurringOrderReference RecurringOrder { get; set; }

        public IList<IPaymentMethodConfiguration> PaymentMethodConfigurations { get; set; }

        public IEnumerable<IPaymentMethodConfiguration> PaymentMethodConfigurationsEnumerable { set => PaymentMethodConfigurations = value.ToList(); }
    }
}
