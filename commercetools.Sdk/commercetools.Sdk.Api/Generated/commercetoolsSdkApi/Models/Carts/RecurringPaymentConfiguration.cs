using System.Collections.Generic;
using System.Linq;

namespace commercetools.Sdk.Api.Models.Carts
{

    public partial class RecurringPaymentConfiguration : IRecurringPaymentConfiguration
    {
        public IPaymentStrategy PaymentStrategy { get; set; }

        public IList<IRecurringPaymentAllocation> PaymentAllocations { get; set; }

        public IEnumerable<IRecurringPaymentAllocation> PaymentAllocationsEnumerable { set => PaymentAllocations = value.ToList(); }
    }
}
