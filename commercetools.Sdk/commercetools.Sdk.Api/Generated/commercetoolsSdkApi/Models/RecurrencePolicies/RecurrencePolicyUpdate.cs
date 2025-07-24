using System.Collections.Generic;
using System.Linq;

namespace commercetools.Sdk.Api.Models.RecurrencePolicies
{

    public partial class RecurrencePolicyUpdate : IRecurrencePolicyUpdate
    {
        public long Version { get; set; }

        public IList<IRecurrencePolicyUpdateAction> Actions { get; set; }

        public IEnumerable<IRecurrencePolicyUpdateAction> ActionsEnumerable { set => Actions = value.ToList(); }
    }
}
