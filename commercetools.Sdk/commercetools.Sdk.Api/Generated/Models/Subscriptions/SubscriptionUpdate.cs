using System.Collections.Generic;
using System.Linq;


namespace commercetools.Sdk.Api.Models.Subscriptions
{

    public partial class SubscriptionUpdate : ISubscriptionUpdate
    {
        public long Version { get; set; }

        public IList<ISubscriptionUpdateAction> Actions { get; set; }
        public IEnumerable<ISubscriptionUpdateAction> ActionsEnumerable { set => Actions = value.ToList(); }

    }
}
