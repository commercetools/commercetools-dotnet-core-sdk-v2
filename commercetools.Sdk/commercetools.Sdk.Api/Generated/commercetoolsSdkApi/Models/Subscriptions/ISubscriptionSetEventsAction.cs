using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Subscriptions
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Subscriptions.SubscriptionSetEventsAction))]
    public partial interface ISubscriptionSetEventsAction : ISubscriptionUpdateAction
    {
        IList<IEventSubscription> Messages { get; set; }

        IEnumerable<IEventSubscription> MessagesEnumerable { set => Messages = value.ToList(); }

    }
}
