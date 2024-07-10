using System.Collections.Generic;
using System.Linq;


namespace commercetools.Sdk.Api.Models.Subscriptions
{

    public partial class SubscriptionSetChangesAction : ISubscriptionSetChangesAction
    {
        public string Action { get; set; }

        public IList<IChangeSubscription> Changes { get; set; }
        public IEnumerable<IChangeSubscription> ChangesEnumerable { set => Changes = value.ToList(); }

        public SubscriptionSetChangesAction()
        {
            this.Action = "setChanges";
        }
    }
}
