using System.Collections.Generic;
using System.Linq;

namespace commercetools.Sdk.Api.Models.Carts
{

    public partial class RecurringPaymentConfigurationDraft : IRecurringPaymentConfigurationDraft
    {
        public IPaymentStrategy PaymentStrategy { get; set; }

        public IList<IPaymentAllocationDraft> PaymentAllocations { get; set; }

        public IEnumerable<IPaymentAllocationDraft> PaymentAllocationsEnumerable { set => PaymentAllocations = value.ToList(); }
    }
}
