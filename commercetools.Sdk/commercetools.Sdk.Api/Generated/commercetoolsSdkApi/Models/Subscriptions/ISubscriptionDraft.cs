using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Subscriptions
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Subscriptions.SubscriptionDraft))]
    public partial interface ISubscriptionDraft
    {
        IDestination Destination { get; set; }

        string Key { get; set; }

        IList<IMessageSubscription> Messages { get; set; }

        IEnumerable<IMessageSubscription> MessagesEnumerable { set => Messages = value.ToList(); }

        IList<IChangeSubscription> Changes { get; set; }

        IEnumerable<IChangeSubscription> ChangesEnumerable { set => Changes = value.ToList(); }

        IList<IEventSubscription> Events { get; set; }

        IEnumerable<IEventSubscription> EventsEnumerable { set => Events = value.ToList(); }

        IDeliveryFormat Format { get; set; }

    }
}
