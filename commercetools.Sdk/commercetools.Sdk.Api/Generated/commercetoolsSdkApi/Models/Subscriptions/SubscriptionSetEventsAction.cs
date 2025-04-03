using System.Collections.Generic;
using System.Linq;

namespace commercetools.Sdk.Api.Models.Subscriptions
{

    public partial class SubscriptionSetEventsAction : ISubscriptionSetEventsAction
    {
        public string Action { get; set; }

        public IList<IEventSubscription> Messages { get; set; }

        public IEnumerable<IEventSubscription> MessagesEnumerable { set => Messages = value.ToList(); }
        public SubscriptionSetEventsAction()
        {
            this.Action = "setEvents";
        }
    }
}
