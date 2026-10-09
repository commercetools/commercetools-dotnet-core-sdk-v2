using System.Collections.Generic;
using System.Linq;

namespace commercetools.Sdk.CheckoutApi.Models.RecurringPayments
{

    public partial class RecurringPaymentUpdateActions : IRecurringPaymentUpdateActions
    {
        public int Version { get; set; }

        public IList<IRecurringPaymentUpdateAction> Actions { get; set; }

        public IEnumerable<IRecurringPaymentUpdateAction> ActionsEnumerable { set => Actions = value.ToList(); }
    }
}
