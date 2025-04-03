using System.Collections.Generic;
using System.Linq;

namespace commercetools.Sdk.Api.Models.Subscriptions
{

    public partial class EventSubscription : IEventSubscription
    {
        public IEventSubscriptionResourceTypeId ResourceTypeId { get; set; }

        public IList<IEventType> Types { get; set; }

        public IEnumerable<IEventType> TypesEnumerable { set => Types = value.ToList(); }
    }
}
