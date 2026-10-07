using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Sdk.CheckoutApi.Models.RecurringPayments
{

    public partial class RecurringPayment : IRecurringPayment
    {
        public string Id { get; set; }

        public int Version { get; set; }

        public string Key { get; set; }

        public IRecurringOrderReference RecurringOrder { get; set; }

        public IList<IPaymentMethodConfiguration> PaymentMethodConfigurations { get; set; }

        public IEnumerable<IPaymentMethodConfiguration> PaymentMethodConfigurationsEnumerable { set => PaymentMethodConfigurations = value.ToList(); }

        public DateTime CreatedAt { get; set; }

        public DateTime LastModifiedAt { get; set; }
    }
}
