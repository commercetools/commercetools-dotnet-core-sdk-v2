using commercetools.Sdk.CheckoutApi.Models.Common;
using commercetools.Sdk.CheckoutApi.Models.Payments;
using commercetools.Sdk.CheckoutApi.Models.RecurringPayments;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Sdk.CheckoutApi.Models.RecurringPaymentJobs
{

    public partial class RecurringPaymentJob : IRecurringPaymentJob
    {
        public string Id { get; set; }

        public int Version { get; set; }

        public string Key { get; set; }

        public IPaymentReference OriginPayment { get; set; }

        public IPaymentMethodReference PaymentMethod { get; set; }

        public IList<IRecurringPaymentReference> RecurringPayments { get; set; }

        public IEnumerable<IRecurringPaymentReference> RecurringPaymentsEnumerable { set => RecurringPayments = value.ToList(); }

        public IRecurringPaymentJobStatus Status { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime LastModifiedAt { get; set; }
    }
}
