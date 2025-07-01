using System.Collections.Generic;
using System.Linq;

namespace commercetools.Sdk.Api.Models.Subscriptions
{

    public partial class SubscriptionSetEventsAction : ISubscriptionSetEventsAction
    {
        public string Action { get; set; }

        public IList<IEventSubscription> Events { get; set; }

        public IEnumerable<IEventSubscription> EventsEnumerable { set => Events = value.ToList(); }
        public SubscriptionSetEventsAction()
        {
            this.Action = "setEvents";
        }
    }
}
