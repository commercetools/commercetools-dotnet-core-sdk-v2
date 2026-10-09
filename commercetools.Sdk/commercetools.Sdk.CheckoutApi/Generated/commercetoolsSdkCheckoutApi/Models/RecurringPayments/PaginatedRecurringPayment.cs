using System.Collections.Generic;
using System.Linq;

namespace commercetools.Sdk.CheckoutApi.Models.RecurringPayments
{

    public partial class PaginatedRecurringPayment : IPaginatedRecurringPayment
    {
        public int Limit { get; set; }

        public int Offset { get; set; }

        public int Count { get; set; }

        public int? Total { get; set; }

        public IList<IRecurringPayment> Results { get; set; }

        public IEnumerable<IRecurringPayment> ResultsEnumerable { set => Results = value.ToList(); }
    }
}
