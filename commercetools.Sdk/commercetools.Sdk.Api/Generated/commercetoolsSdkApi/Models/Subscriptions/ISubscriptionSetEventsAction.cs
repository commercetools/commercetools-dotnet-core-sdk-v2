using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Subscriptions
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Subscriptions.SubscriptionSetEventsAction))]
    public partial interface ISubscriptionSetEventsAction : ISubscriptionUpdateAction
    {
        IList<IEventSubscription> Events { get; set; }

        IEnumerable<IEventSubscription> EventsEnumerable { set => Events = value.ToList(); }

    }
}
