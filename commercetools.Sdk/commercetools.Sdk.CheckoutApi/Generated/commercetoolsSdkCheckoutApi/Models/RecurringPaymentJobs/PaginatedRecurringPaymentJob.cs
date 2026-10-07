using System.Collections.Generic;
using System.Linq;

namespace commercetools.Sdk.CheckoutApi.Models.RecurringPaymentJobs
{

    public partial class PaginatedRecurringPaymentJob : IPaginatedRecurringPaymentJob
    {
        public int Limit { get; set; }

        public int Offset { get; set; }

        public int Count { get; set; }

        public int? Total { get; set; }

        public IList<IRecurringPaymentJob> Results { get; set; }

        public IEnumerable<IRecurringPaymentJob> ResultsEnumerable { set => Results = value.ToList(); }
    }
}
