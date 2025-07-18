using System.Collections.Generic;
using System.Linq;

namespace commercetools.Sdk.Api.Models.RecurringOrders
{

    public partial class RecurringOrderUpdate : IRecurringOrderUpdate
    {
        public long Version { get; set; }

        public IList<IRecurringOrderUpdateAction> Actions { get; set; }

        public IEnumerable<IRecurringOrderUpdateAction> ActionsEnumerable { set => Actions = value.ToList(); }
    }
}
