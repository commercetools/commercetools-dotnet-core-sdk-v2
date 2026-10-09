using System.Collections.Generic;
using System.Linq;

namespace commercetools.Sdk.CheckoutApi.Models.RecurringPaymentJobs
{

    public partial class RecurringPaymentJobStatus : IRecurringPaymentJobStatus
    {
        public IRecurringPaymentJobState State { get; set; }

        public int? Attempts { get; set; }

        public IList<IRecurringPaymentJobError> Errors { get; set; }

        public IEnumerable<IRecurringPaymentJobError> ErrorsEnumerable { set => Errors = value.ToList(); }
    }
}
