using System.Collections.Generic;
using System.Linq;

namespace commercetools.Sdk.Api.Models.Subscriptions
{

    public partial class SubscriptionDraft : ISubscriptionDraft
    {
        public IList<IChangeSubscription> Changes { get; set; }

        public IEnumerable<IChangeSubscription> ChangesEnumerable { set => Changes = value.ToList(); }

        public IDestination Destination { get; set; }

        public string Key { get; set; }

        public IList<IMessageSubscription> Messages { get; set; }

        public IEnumerable<IMessageSubscription> MessagesEnumerable { set => Messages = value.ToList(); }

        public IList<IEventSubscription> Events { get; set; }

        public IEnumerable<IEventSubscription> EventsEnumerable { set => Events = value.ToList(); }

        public IDeliveryFormat Format { get; set; }
    }
}
